// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Buff_ApplyBuffOnPrimaryHit_DataShared
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
  public struct Buff_ApplyBuffOnPrimaryHit_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ProcChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProcBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageDealtListener;
    [FieldOffset(0)]
    public float ProcChance;
    [FieldOffset(4)]
    public PrefabGUID ProcBuff;
    [FieldOffset(8)]
    public ListenerId OnDamageDealtListener;

    static Buff_ApplyBuffOnPrimaryHit_DataShared()
    {
      Il2CppClassPointerStore<Buff_ApplyBuffOnPrimaryHit_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Buff_ApplyBuffOnPrimaryHit_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff_ApplyBuffOnPrimaryHit_DataShared>.NativeClassPtr);
      Buff_ApplyBuffOnPrimaryHit_DataShared.NativeFieldInfoPtr_ProcChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_ApplyBuffOnPrimaryHit_DataShared>.NativeClassPtr, nameof (ProcChance));
      Buff_ApplyBuffOnPrimaryHit_DataShared.NativeFieldInfoPtr_ProcBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_ApplyBuffOnPrimaryHit_DataShared>.NativeClassPtr, nameof (ProcBuff));
      Buff_ApplyBuffOnPrimaryHit_DataShared.NativeFieldInfoPtr_OnDamageDealtListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_ApplyBuffOnPrimaryHit_DataShared>.NativeClassPtr, nameof (OnDamageDealtListener));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff_ApplyBuffOnPrimaryHit_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
