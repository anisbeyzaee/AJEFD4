import java.io.File;
import java.io.IOException;

public class ClassifierProject {
	private static String lastGui = "";
	private static String imagePathName ;
	public ClassifierProject() throws IOException{
		
		File file = new File("C://Users//Meg//Downloads//networkInfoFile.xml");
		ReadXML myReadXML = new ReadXML(file);
		FileInfo myFileInfo = new FileInfo(imagePathName);
		ImageProcessor myImageProcessor = new ImageProcessor(myReadXML, myFileInfo);
		NetworkClassifier myNetwork = new NetworkClassifier(myReadXML, myImageProcessor);
		System.out.println("Hidden unit count " + myReadXML.getHiddenUnitCount());
		System.out.println("Get hidden units length: " + myNetwork.getHiddenUnits().length);
	
		System.out.println();
		myNetwork.determineFire();
		
	}
	
	public static void main(String[] args) throws IOException {
		
		//String imagePathName =  args[0];
		String imagePathNAme = "C:\\Users\\anisb\\source\\repos\\AJEFD4\\LocalTestImages\\123.JPG";
		if(ImageIsTheMostRecent(imagePathName)) {
			
		}
		ClassifierProject myClassifierProject = new ClassifierProject();
	}
	private static boolean ImageIsTheMostRecent(String imagePathName) {
		String[] values = imagePathName.split(",");
		if(!values[0].equals(lastGui))
		{
			imagePathName = values[1];
			return true;
		}
		return false;
	}
}
