using Microsoft.AspNetCore.Mvc;

namespace TasksAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        // Exercise 1

        [HttpGet("Ex1")]
        public IActionResult Get(int id)
        {
            return Ok($"Get exercise with id {id}");
        }

        // Exercise 2

        [HttpGet("Ex2")]
        public IActionResult GetSum(double param1, double param2)
        {
            double sum = param1 + param2;

            return Ok($"{param1} + {param2} = {sum}");
        }

        // Exercise 3

        [HttpPost("Ex3")]
        public IActionResult GetListSum([FromBody] List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return BadRequest("No numbers provided");
            }

            double sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            numbers.Add(sum);

            return Ok($"Sum of numbers: {sum}");
        }

        // Exercise 4

        private static readonly List<string> StringList = new List<string> { "EX1", "EX2", "EX3" };

        [HttpGet("Ex4")]
        public IActionResult GetStringList()
        {
            return Ok(StringList);
        }

        // Exercise 5

        private static readonly List<string> Names = new List<string> { "ana", "vasile", "gheorghe", "maria", "ion" };

        [HttpPost("Ex5")]
        public IActionResult UpdateName(int index, [FromBody] string newName)
        {
            if (Names.Count == 0)
            {
                return BadRequest("No names provided");
            }

            if (index < 0 || index >= Names.Count)
            {
                return BadRequest("Index out of bounds");
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                return BadRequest("Invalid new name");
            }

            for (int i = 0; i < Names.Count; i++)
            {
                if (Names[i] == null)
                {
                    return BadRequest("Null value found");
                }
            }

            for (int i = 0; i < Names.Count; i++)
            {
                if (Names[index] == newName)
                {
                    return BadRequest("Name already exists");
                }
            }

            Names[index] = newName;

            return Ok(Names);
        }

        // Exercise 6

        [HttpGet("Ex6")]
        public IActionResult DeleteNameWithPosition(int position)
        {
            Names.RemoveAt(position);

            return Ok(Names);
        }
    }
}