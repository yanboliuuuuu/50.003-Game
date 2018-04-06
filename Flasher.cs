public class Flasher : IEffect {

	public bool IsRunning { get; set; }
	public bool IsVisible { get; set; }

	int delay;
	int counter = 0;
	int totalPartialFlashes;
	int currentPartialFlashes = 0;

	public Flasher(int totalFlashes, int delay){
		IsRunning = false;
		IsVisible = true;
		this.totalPartialFlashes = totalFlashes * 2;
		this.delay = delay;
	}

	// Use this for initialization
	public void Start () {
		if (!IsRunning) {
			IsRunning = true;
		}
	}
	
	// Update is called once per frame
	public void Update () {
		if (!IsRunning) {
			return;
		}

		if (currentPartialFlashes == totalPartialFlashes) {
			Reset ();
			return;
		}

		if (counter == 0) {
			Flash ();
		}

		IncrementCounter ();
	}

	void IncrementCounter(){
		counter = (counter + 1) % delay;
	}

	void Flash(){
		IsVisible = !IsVisible;
		currentPartialFlashes += 1;
	}

	void Reset(){
		IsVisible = true;
		IsRunning = false;
		currentPartialFlashes = 0;
		counter = 0;
	}

}
