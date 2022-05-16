namespace KarenLogic {
  public class Store {
    private Karen karen;
    private bool containsOwner;

    public Store(Karen karen) {
      this.karen = karen;
    }

    public void ActivateTheKaren() {
      karen.Appear();
    }

    public void OwnerWalksIn() {
      containsOwner = true;
    }

    public void ResetOwner() {
      containsOwner = false;
    }

    public void Update() {
      if (karen.IsPresent && containsOwner) {
        karen.Damage(1);
      }
    }
  }
    public class Store1
    {
        private Karen karen;
        private bool containsOwner;

        public Store1(Karen karen)
        {
            this.karen = karen;
        }

        public void ActivateTheKaren()
        {
            karen.Appear();
        }

        public void OwnerWalksIn()
        {
            containsOwner = true;
        }

        public void ResetOwner()
        {
            containsOwner = false;
        }

        public void Update()
        {
            if (karen.IsPresent && containsOwner)
            {
                karen.Damage(1);
            }
        }
    }
}
