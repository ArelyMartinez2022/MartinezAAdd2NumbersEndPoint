/*
ARELY MARTINEZ 
OCT 25, 2022 11:23AM
THIS PROGRAM WILL MAKE IT SO THAT THE 
USER CAN INPUT TWO NUMBERS AND IT REPSOND 
WITH THE SUM. THEY WOULD 
INPUT THROUGH POSTMAN LIKE 
OUTPUT: https://localhost:7119/input/ADDING/2/5
OUTPUT: 2 + 5 = 7
PEER REVIEW: NAME -- REVIEW Samuel Laguna
I ran the code it works good. The inputs 
work just fine. There where no erros, this 
code is all good.
*/

using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("Adding")]
    public string MathIt( )
    {

        return "LETS ADD TWO NUMBERS!! ";
    }

    [HttpGet]
    [Route("Adding/{number1}/{number2}")]
    public string Mathhhhh(string number1, string number2 )
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 =  Convert.ToInt32(number2);
        int answer =  convertNum1 + convertNum2;
        return $"{convertNum1} + {convertNum2} = {answer} ";
    }
    
    //return$"This would be my return {var} "
}
