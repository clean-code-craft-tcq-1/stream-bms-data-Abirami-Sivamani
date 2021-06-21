package receiver;

import static org.junit.Assert.assertTrue;

import org.junit.Test;

public class ReceiverTest 
{
	private IntegerStack data = new IntegerStack(5,"Test");
    @Test
    public void parametersUpdate_whenDataIsPushed()
    {
    	data.push(5);  // [5]
    	data.push(10); // [5,10]
    	data.push(15); // [5,10,15]
        assertTrue( data.getMin() == 5 );
        assertTrue( data.getMax() == 15 );
        assertTrue( data.getAvg() == 10 );
    }
    
    @Test
    public void parametersRetain_whenNewDataIsPushed()
    {
    	data.push(5);  // [5]
    	data.push(10); // [5,10]
    	data.push(15); // [5,10,15]
    	data.push(20); // [5,10,15,20]
    	data.push(25); // [5,10,15,20,25] 
    	data.push(30); // [10,15,20,25,30]
    	assertTrue( data.getMin() == 10 );
        assertTrue( data.getMax() == 30 );
        assertTrue( data.getAvg() == 20 );
    }
}
