// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Stagger
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Stagger
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerMaxHp;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerRecoveryDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastHitTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerHp;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerMaxHpFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerRecoveryRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerBuffGUID;
    [FieldOffset(0)]
    public ModifiableFloat StaggerMaxHp;
    [FieldOffset(8)]
    public double StaggerRecoveryDelay;
    [FieldOffset(16)]
    public double LastHitTime;
    [FieldOffset(24)]
    public float StaggerHp;
    [FieldOffset(28)]
    public float StaggerMaxHpFactor;
    [FieldOffset(32)]
    public float StaggerRecoveryRate;
    [FieldOffset(36)]
    public PrefabGUID StaggerBuffGUID;

    static Stagger()
    {
      Il2CppClassPointerStore<Stagger>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Stagger));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stagger>.NativeClassPtr);
      Stagger.NativeFieldInfoPtr_StaggerMaxHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stagger>.NativeClassPtr, nameof (StaggerMaxHp));
      Stagger.NativeFieldInfoPtr_StaggerRecoveryDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stagger>.NativeClassPtr, nameof (StaggerRecoveryDelay));
      Stagger.NativeFieldInfoPtr_LastHitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stagger>.NativeClassPtr, nameof (LastHitTime));
      Stagger.NativeFieldInfoPtr_StaggerHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stagger>.NativeClassPtr, nameof (StaggerHp));
      Stagger.NativeFieldInfoPtr_StaggerMaxHpFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stagger>.NativeClassPtr, nameof (StaggerMaxHpFactor));
      Stagger.NativeFieldInfoPtr_StaggerRecoveryRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stagger>.NativeClassPtr, nameof (StaggerRecoveryRate));
      Stagger.NativeFieldInfoPtr_StaggerBuffGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stagger>.NativeClassPtr, nameof (StaggerBuffGUID));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Stagger>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
