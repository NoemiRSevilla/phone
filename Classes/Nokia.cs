using System;
using phone.Interfaces;

namespace phone.Classes
{
    public class Nokia : Phone, IRingable
    {
        public Nokia (string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone)
        {} 
        public string Ring()
        {
            return $"Ring: {_ringTone}";
        }
        public string Unlock()
        {
            return $"Galaxy {_versionNumber} unlocked with fingerprint scanner";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Version number: {_versionNumber}, battery at {_batteryPercentage} percent, carrier: {_carrier}, ringtone: {_ringTone}");
        }
    }
}