// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Spectral_Empower_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Spectral_Empower_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageDealtListener;
    [FieldOffset(0)]
    public KnockbackPower KnockbackPower;
    [FieldOffset(180)]
    public float KnockbackDuration;
    [FieldOffset(184)]
    public float KnockbackRange;
    [FieldOffset(188)]
    public float DamageBonus;
    [FieldOffset(192)]
    public ListenerId OnDamageDealtListener;

    static Script_Spectral_Empower_DataServer()
    {
      Il2CppClassPointerStore<Script_Spectral_Empower_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Spectral_Empower_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Spectral_Empower_DataServer>.NativeClassPtr);
      Script_Spectral_Empower_DataServer.NativeFieldInfoPtr_KnockbackPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Spectral_Empower_DataServer>.NativeClassPtr, nameof (KnockbackPower));
      Script_Spectral_Empower_DataServer.NativeFieldInfoPtr_KnockbackDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Spectral_Empower_DataServer>.NativeClassPtr, nameof (KnockbackDuration));
      Script_Spectral_Empower_DataServer.NativeFieldInfoPtr_KnockbackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Spectral_Empower_DataServer>.NativeClassPtr, nameof (KnockbackRange));
      Script_Spectral_Empower_DataServer.NativeFieldInfoPtr_DamageBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Spectral_Empower_DataServer>.NativeClassPtr, nameof (DamageBonus));
      Script_Spectral_Empower_DataServer.NativeFieldInfoPtr_OnDamageDealtListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Spectral_Empower_DataServer>.NativeClassPtr, nameof (OnDamageDealtListener));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Spectral_Empower_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
