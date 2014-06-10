namespace System {
	public static class EventExtensions {
	    public static void Raise(this EventHandler @event, object sender) {
	        Raise(@event, sender, EventArgs.Empty);
	    }

	    public static void Raise(this EventHandler @event, object sender, EventArgs args) {
	        if (@event != null)
	            @event(sender, args);
	    }

        public static void Raise<T>(this EventHandler<T> @event, object sender, T args) where T : EventArgs {
            if (@event != null)
                @event(sender, args);
        }
    }
}
