// Decompiled with JetBrains decompiler
// Type: LocalizedStatType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct LocalizedStatType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_StatType;
  private static readonly System.IntPtr NativeFieldInfoPtr_ValueKey;
  [FieldOffset(0)]
  public UnitStatType StatType;
  [FieldOffset(4)]
  public LocalizationKey ValueKey;

  static LocalizedStatType()
  {
    Il2CppClassPointerStore<LocalizedStatType>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (LocalizedStatType));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStatType>.NativeClassPtr);
    LocalizedStatType.NativeFieldInfoPtr_StatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStatType>.NativeClassPtr, nameof (StatType));
    LocalizedStatType.NativeFieldInfoPtr_ValueKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStatType>.NativeClassPtr, nameof (ValueKey));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedStatType>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
