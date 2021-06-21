package receiver;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class IntegerStack {
	private List<Integer> data;
	private int size;
	private String title;
	private String alertFormat = "Raw Data: %s\nMin %s: %d\nMax %s: %d\nAverage %s: %f\n";
	
	public IntegerStack(int size, String title) {
		this.data = new ArrayList<>();
		this.size = size;
		this.title = title;
	}
	
	public void push(int val) {
		data.add(val);
		if(size < data.size())
			pop();
		alert();
		
	}
	
	public Integer getMin() {return Collections.min(data);}
	public Integer getMax() {return Collections.max(data);}
	
	private Integer pop() {
		if(data.size()>0)
			return data.remove(0);
		else
			return null;
	}
	
	public double getAvg() {
	  Integer sum = 0;
	  if(!data.isEmpty()) {
	    for (Integer val : data) {
	        sum += val;
	    }
	    return sum.doubleValue() / data.size();
	  }
	  return sum;
	}
	
	public void alert() {
		if(data.size()==size)
			System.out.printf(
					alertFormat,
					data.toString(),
					title,getMin(),
					title,getMax(),
					title,getAvg()
				);
	}
}
