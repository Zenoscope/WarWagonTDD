using NUnit.Framework;

namespace EntityTests
{

  // should there be bounds checking tests or should the tests 
    
   public class EntityTests
    {

      private Entity.Entity myEntity;
      
      int moveAmount = 10;
      
      [SetUp]
      public void Setup()
      {
          myEntity = new Entity.Entity();
      }

      // Spawn location
      [Test]
      public void setXSpawnLoc(){
        Assert.That(myEntity.set_x_spawn(),Is.EqualTo(0));
      }

      [Test]
      public void setYSpawnLoc(){
        Assert.That(myEntity.set_y_spawn(),Is.EqualTo(0));
      }

      [Test]
      // get
      public void getEntityXLocation() {
        Assert.That(myEntity.get_x_loc(),Is.EqualTo(0));          
      }

      [Test]
      public void getEntityYLocation() {
        Assert.That(myEntity.get_y_loc(),Is.EqualTo(0));
      }

      [Test]
      // set
      public void setEntityXLocation() {
        
      }

      [Test]
      public void setEntityYLocation() {
        Assert.That(myEntity.set_y_loc(moveAmount),Is.EqualTo(moveAmount));
      }

      [Test]
      public void getEntityXLocationAgain() {
        Assert.That(myEntity.get_x_loc(),Is.EqualTo(10));
      }

      [Test]
      public void getEntityYLocationAgain() {
        Assert.That(myEntity.get_y_loc(),Is.EqualTo(10));
      }
      
      [Test]
      public void setNewEntityXLocation() {
        Assert.That(myEntity.set_x_loc(-20),Is.EqualTo(-10));
      }

      [Test]
      public void getNewEntityYLocation() {
        Assert.That(myEntity.get_y_loc(),Is.EqualTo(10));
      }

      // Health
      [Test]
      public void setEntityMaxHealth() {
        int maxHealth = 100;
        Assert.That(myEntity.setMaxHealth(MaxHealth),Is.EqualTo(100));
      }

      [Test]
      public void getEntityHealth() {
        Assert.That(myEntity.getHealth(),Is.EqualTo(100));
      }
      
      public void injureEntity() {
        int injuryAmount = 25;
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(75));
      }
      
      public void healEntity() {
        int healAmount = 25;
        Assert.That(myEntity.addToHealth(healAmount),Is.EqualTo(100));
      }
      
      public void killEntity() {
        int injuryAmount = 25;
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(75))
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(50))
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(25))
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(0))
        // subtractFromHealth:
        // if _health == 0 then dieEntity()
        // if String entityType = "Enemy";
        // entity class enum for enemy health, gem value, mesh
        // also armour?
      }

      public void overHealEntity() {
        int healAmount = 25;
        Assert.That(myEntity.addToHealth(healAmount),Is.EqualTo(100));
        Assert.That(myEntity.addToHealth(healAmount),Is.EqualTo(100));
        Assert.That(myEntity.getHealth(),Is.EqualTo(100));
        // oveHealHealth:
        // if _health > maxHealth then _health = maxHealth;
      }

       public void dieEntity(){
          // if type is enemy:
          // depending on the weapon used, play the death animation
          // eg the scythe cuts the mesh and the top half pops up ad sprays blood everywhere
          // the anvil squashes them into the ground
          // the torc cuts off heads (?)
          // spawn a gem. 
          // if the type is player, i guess the wagon gets wrecked and the weapons all fly out and
          // things all break or there is a death explosion or something and then you restart          
       }
       
      // Collect a gem
      public void collectAGem(){
         String entityType = "Enemy";
         Assert.That(myEntity.collectGem(),Is.EqualTo("Enemy"));
         
         String entityType = "Player";
         Assert.That(myEntity.collectGem(),Is.EqualTo("Player"));
         
         // if the gem is collected by an enemy..
         // delete the gem mesh (also used by dieEntity)
         // add the gem value to the armour/health of the enemy entity, to a max value (%?)
         // add the gem to the GemCount
      }
      
      public void checkGemStage(){
         int currentGemLevel = 0;
        // check the current level, each gem level should have a level (number or percentage)
        // if the level reaches the threshold, then gems is 0 and level goes up.
        Assert.That(myEntity.checkGemLevel(currentGemLevel),Is.EqualTo("1")); 
      }

      // player specific stuff: 
       
      // **** Weapons for wagon
      // set up a list of weapons (should be in another class)
      // get/set weapon list for entity (name, damage, upgrade path, type)
      // weapon types: held (fixed point on model), 
      // default weapons as part of entity type/default variables      
      
       // ***level up weapons
      // grab 2 random weapons and one current weapon from the weapon list to upgrade  
       
    }
}
