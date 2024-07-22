using Microsoft.AspNetCore.Mvc;

namespace StringReversalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringReversalController : Controller
    {
        StringHelper stringHelper;

        public StringReversalController()
        {
            stringHelper = new StringHelper();
        }

        [HttpGet("reverseStringAndCheckPalindrome")]
        public IActionResult ReverseStringAndCheckPalindrome(string inputString) 
        {
            //first check if string is not empty or it is not a null value.
            if (string.IsNullOrEmpty(inputString)) 
            {
                return BadRequest("Input string must not be null or empty.");
            }

            //reverse the string and check if 
            var reversedString = stringHelper.ReverseString(inputString);
            var isPalindrome = stringHelper.IsPalindrome(inputString);

            var result = new
            {
                ReversedString = reversedString,
                IsPalindrome = isPalindrome
            };

            return Ok(result);
        }
    }
}
