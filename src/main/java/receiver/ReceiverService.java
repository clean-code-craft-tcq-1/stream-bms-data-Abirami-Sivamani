package receiver;

public class ReceiverService {
	public static IDataReader reader = new ConsoleReader();
	public static IDataProcessor processor = new StreamProcessor();
	
	public static void setReader(IDataReader reader) {
		if(reader != null)
			ReceiverService.reader = reader;
	}
	
	public static void receiveStream() {
		while(true) {
			String raw = reader.getNext();
			if(raw==null)
				break;
			processor.process(raw);
		}
	}
}
