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
        Assert.That(myEntity.setXSpawn(),Is.EqualTo(0));
      }

      [Test]
      public void setZSpawnLoc(){
        Assert.That(myEntity.setZSpawn(),Is.EqualTo(0));
      }
    
      [Test]      
      //  not moved yet, just checking where we are.
      public void getEntityXLocation() {
        Assert.That(myEntity.getXLoc(),Is.EqualTo(0));          
      }

      [Test]      
      public void getEntityZLocation() {
        Assert.That(myEntity.getZLoc(),Is.EqualTo(0));
      }

      [Test]
      public void setEntityXLocation() {
        // move in positive direction
        Assert.That(myEntity.setXLoc(moveAmount),Is.EqualTo(moveAmount));
        Assert.That(myEntity.getXLoc(),Is.EqualTo(moveAmount));
        // move vack to zero
        Assert.That(myEntity.setXLoc(-moveAmount),Is.EqualTo(0));
        Assert.That(myEntity.getXLoc(),Is.EqualTo(0));        
      }

      [Test]
      public void setEntityZLocation() {
        // move in positive direction
        Assert.That(myEntity.setZLoc(moveAmount),Is.EqualTo(moveAmount));
        Assert.That(myEntity.getZLoc(),Is.EqualTo(moveAmount));
        // move vack to zero
        Assert.That(myEntity.setZLoc(-moveAmount),Is.EqualTo(0));
        Assert.That(myEntity.getZLoc(),Is.EqualTo(0));        
      }
      
      
      // Health tests
      int maxHealth = 105;

      [Test]      
      public void spawnSetEntityHealth() {
        // set max health and current health.
        Assert.That(myEntity.spawnSetHealth(maxHealth),Is.EqualTo(maxHealth));
      }
      
      [Test]      
      public void getEntityHealth() {
        Console.WriteLine("Getting health");              
        Assert.That(myEntity.getHealth(),Is.EqualTo(maxHealth));
      }

      /*      
      [Test]
      [Ignore("not written")]
      public void injureEntity() {
        int injuryAmount = 25;
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(75));
      }
      
      [Test]
      [Ignore("not written")]
      public void healEntity() {
        int healAmount = 25;
        Assert.That(myEntity.addToHealth(healAmount),Is.EqualTo(100));
      }
      
      [Test]
      [Ignore("not written")]
      public void killEntity() {
        int injuryAmount = 25;
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(75));
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(50));
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(25));
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(0));
        // subtractFromHealth:
        // if _health == 0 then dieEntity()
        // if String entityType = "Enemy";
        // entity class enum for enemy health, gem value, mesh
        // also armour?
      }

      [Test]
      [Ignore("not written")]
      public void overHealEntity() {
        int healAmount = 25;
        Assert.That(myEntity.addToHealth(healAmount),Is.EqualTo(100));
        Assert.That(myEntity.addToHealth(healAmount),Is.EqualTo(100));
        Assert.That(myEntity.getHealth(),Is.EqualTo(100));
        // oveHealHealth:
        // if _health > maxHealth then _health = maxHealth;
      }


      [Test]
      [Ignore("not written")]
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

      [Test]
      [Ignore("not written")]
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

      [Test]
      [Ignore("not written")]
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
      */
    }
}
