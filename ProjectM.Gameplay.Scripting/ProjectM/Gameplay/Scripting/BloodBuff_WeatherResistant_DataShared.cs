// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_WeatherResistant_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_WeatherResistant_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistanceFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HolyModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SilverModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_GarlicModificationId;
    [FieldOffset(0)]
    public float BloodQualityThreshold;
    [FieldOffset(4)]
    public float ResistanceFactor;
    [FieldOffset(8)]
    public ModificationId HolyModificationId;
    [FieldOffset(12)]
    public ModificationId SilverModificationId;
    [FieldOffset(16)]
    public ModificationId GarlicModificationId;

    static BloodBuff_WeatherResistant_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_WeatherResistant_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_WeatherResistant_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_WeatherResistant_DataShared>.NativeClassPtr);
      BloodBuff_WeatherResistant_DataShared.NativeFieldInfoPtr_BloodQualityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_WeatherResistant_DataShared>.NativeClassPtr, nameof (BloodQualityThreshold));
      BloodBuff_WeatherResistant_DataShared.NativeFieldInfoPtr_ResistanceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_WeatherResistant_DataShared>.NativeClassPtr, nameof (ResistanceFactor));
      BloodBuff_WeatherResistant_DataShared.NativeFieldInfoPtr_HolyModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_WeatherResistant_DataShared>.NativeClassPtr, nameof (HolyModificationId));
      BloodBuff_WeatherResistant_DataShared.NativeFieldInfoPtr_SilverModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_WeatherResistant_DataShared>.NativeClassPtr, nameof (SilverModificationId));
      BloodBuff_WeatherResistant_DataShared.NativeFieldInfoPtr_GarlicModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_WeatherResistant_DataShared>.NativeClassPtr, nameof (GarlicModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_WeatherResistant_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
