using System;
using phone.Interfaces;

namespace phone.Classes
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercent, string carrier, string ringTone) : base(versionNumber, batteryPercent, carrier, ringTone){}
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