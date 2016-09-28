import scala.io.StdIn.{readLine, readInt}
object ScalaTut1 {
	def main(args: Array[String]){
        def myPrint()
        {
	        var x= readLine.toInt
            for(i<- x to 3;j<- 4 to 7)
            {
                printf(s"i : %d", i )
                println("j : " + j)

            }
        }
        
        //myPrint
        
        def getSum(n1:Int = 1 ,n2:Int=1):Int =
        {
            return n1+n2
        }
        
/*        println(getSum(2,4))
        println(getSum(2))   
        println(getSum())*/
        def fact(num: BigInt) : BigInt = {
            if(num<=1)
                1
            else
                num * fact(num-1)
        }
        
        //println(fact(8));
        
        var an = new Animal("dog");

	}
    
    class Animal(var name: String, sound: String){
        this.setName(name);
        val id= Animal.newIdNum

        
        def setName(name: String){
            println(name)
        }
        def this(name:String){
            this("cat", "no sound")
        }
        
    }
}
	