public interface IEffect{
	bool IsRunning { get; set; }
	bool IsVisible { get; set; }
	void Start();
	void Update();
}