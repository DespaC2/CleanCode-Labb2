using BookService.Interfaces;
using BookService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookRepository _bookRepository;
    private readonly HttpClient _httpClient;

    public BookController(IBookRepository bookRepository, HttpClient httpClient)
    {
        _bookRepository = bookRepository;
        _httpClient = httpClient;
    }

    [HttpPost]
    public async Task<IActionResult> AddBook([FromBody] Books book)
    {
        if (book == null)
        {
            return BadRequest("Bokdata saknas.");
        }

        await _bookRepository.AddAsync(book);
        return Ok("Boken har lagts till.");
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBooks()
    {
        var response = await _httpClient.GetAsync("api/external/books");

        if (response.IsSuccessStatusCode)
        {
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return Ok(new List<Books>());
            }

            var allBooks = await response.Content.ReadFromJsonAsync<List<Books>>();
            return Ok(allBooks);
        }

        return StatusCode((int)response.StatusCode, "Misslyckades med att hämta böcker.");
    }
}
