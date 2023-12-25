// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Buff_HealAttackerOnDamageType_DataShared
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
  public struct Buff_HealAttackerOnDamageType_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LeechFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxLeech;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentLeech;
    [FieldOffset(0)]
    public float LeechFactor;
    [FieldOffset(4)]
    public ListenerId OnDamageTakenListener;
    [FieldOffset(12)]
    public MainDamageType DamageType;
    [FieldOffset(16)]
    public float MaxLeech;
    [FieldOffset(20)]
    public float CurrentLeech;

    static Buff_HealAttackerOnDamageType_DataShared()
    {
      Il2CppClassPointerStore<Buff_HealAttackerOnDamageType_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Buff_HealAttackerOnDamageType_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff_HealAttackerOnDamageType_DataShared>.NativeClassPtr);
      Buff_HealAttackerOnDamageType_DataShared.NativeFieldInfoPtr_LeechFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealAttackerOnDamageType_DataShared>.NativeClassPtr, nameof (LeechFactor));
      Buff_HealAttackerOnDamageType_DataShared.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealAttackerOnDamageType_DataShared>.NativeClassPtr, nameof (OnDamageTakenListener));
      Buff_HealAttackerOnDamageType_DataShared.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealAttackerOnDamageType_DataShared>.NativeClassPtr, nameof (DamageType));
      Buff_HealAttackerOnDamageType_DataShared.NativeFieldInfoPtr_MaxLeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealAttackerOnDamageType_DataShared>.NativeClassPtr, nameof (MaxLeech));
      Buff_HealAttackerOnDamageType_DataShared.NativeFieldInfoPtr_CurrentLeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_HealAttackerOnDamageType_DataShared>.NativeClassPtr, nameof (CurrentLeech));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff_HealAttackerOnDamageType_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
