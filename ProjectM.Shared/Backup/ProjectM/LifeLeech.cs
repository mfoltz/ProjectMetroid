// Decompiled with JetBrains decompiler
// Type: ProjectM.LifeLeech
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LifeLeech
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalLifeLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellLifeLeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AffectRecovery;
    [FieldOffset(0)]
    public ModifiableFloat PrimaryLeechFactor;
    [FieldOffset(8)]
    public ModifiableFloat PhysicalLifeLeechFactor;
    [FieldOffset(16)]
    public ModifiableFloat SpellLifeLeechFactor;
    [FieldOffset(24)]
    public bool AffectRecovery;

    static LifeLeech()
    {
      Il2CppClassPointerStore<LifeLeech>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LifeLeech));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LifeLeech>.NativeClassPtr);
      LifeLeech.NativeFieldInfoPtr_PrimaryLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeech>.NativeClassPtr, nameof (PrimaryLeechFactor));
      LifeLeech.NativeFieldInfoPtr_PhysicalLifeLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeech>.NativeClassPtr, nameof (PhysicalLifeLeechFactor));
      LifeLeech.NativeFieldInfoPtr_SpellLifeLeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeech>.NativeClassPtr, nameof (SpellLifeLeechFactor));
      LifeLeech.NativeFieldInfoPtr_AffectRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifeLeech>.NativeClassPtr, nameof (AffectRecovery));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LifeLeech>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
