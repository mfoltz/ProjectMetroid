// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Assault_DataShared
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
  public struct BloodBuff_Assault_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageDealtListener;
    [FieldOffset(0)]
    public float DamageBonus;
    [FieldOffset(4)]
    public ListenerId OnDamageDealtListener;

    static BloodBuff_Assault_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Assault_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Assault_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Assault_DataShared>.NativeClassPtr);
      BloodBuff_Assault_DataShared.NativeFieldInfoPtr_DamageBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Assault_DataShared>.NativeClassPtr, nameof (DamageBonus));
      BloodBuff_Assault_DataShared.NativeFieldInfoPtr_OnDamageDealtListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Assault_DataShared>.NativeClassPtr, nameof (OnDamageDealtListener));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Assault_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
