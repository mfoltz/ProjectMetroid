﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Sorcerrer_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Sorcerrer_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellPowerMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModificationId;
    [FieldOffset(0)]
    public float BloodQualityThreshold;
    [FieldOffset(4)]
    public float SpellPowerMax;
    [FieldOffset(8)]
    public ModificationId SpellModificationId;

    static BloodBuff_Sorcerrer_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Sorcerrer_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Sorcerrer_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Sorcerrer_DataShared>.NativeClassPtr);
      BloodBuff_Sorcerrer_DataShared.NativeFieldInfoPtr_BloodQualityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Sorcerrer_DataShared>.NativeClassPtr, nameof (BloodQualityThreshold));
      BloodBuff_Sorcerrer_DataShared.NativeFieldInfoPtr_SpellPowerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Sorcerrer_DataShared>.NativeClassPtr, nameof (SpellPowerMax));
      BloodBuff_Sorcerrer_DataShared.NativeFieldInfoPtr_SpellModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Sorcerrer_DataShared>.NativeClassPtr, nameof (SpellModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Sorcerrer_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
