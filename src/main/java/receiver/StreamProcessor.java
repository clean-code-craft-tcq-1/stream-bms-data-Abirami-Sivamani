package receiver;

public class StreamProcessor implements IDataProcessor{
	
	private static final String DELIMITER = " ";
	private IntegerStack tempStack = new IntegerStack(5, "Temperature");
	private IntegerStack socStack = new IntegerStack(5, "SOC");

	@Override
	public void process(String raw) {
		String[] parsedText = raw.split(DELIMITER);
		if(parsedText.length < 4)
			return;
		tempStack.push(Integer.parseInt(parsedText[1]));
		socStack.push(Integer.parseInt(parsedText[3]));
	}

}
