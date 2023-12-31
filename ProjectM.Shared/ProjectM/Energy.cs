// Decompiled with JetBrains decompiler
// Type: ProjectM.Energy
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Energy
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxEnergy;
    private static readonly System.IntPtr NativeFieldInfoPtr_GainPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegainEnergyChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public ModifiableFloat MaxEnergy;
    [FieldOffset(8)]
    public ModifiableFloat GainPerSecond;
    [FieldOffset(16)]
    public ModifiableFloat RegainEnergyChance;
    [FieldOffset(24)]
    public float Value;

    static Energy()
    {
      Il2CppClassPointerStore<Energy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Energy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Energy>.NativeClassPtr);
      Energy.NativeFieldInfoPtr_MaxEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Energy>.NativeClassPtr, nameof (MaxEnergy));
      Energy.NativeFieldInfoPtr_GainPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Energy>.NativeClassPtr, nameof (GainPerSecond));
      Energy.NativeFieldInfoPtr_RegainEnergyChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Energy>.NativeClassPtr, nameof (RegainEnergyChance));
      Energy.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Energy>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Energy>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
