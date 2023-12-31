// Decompiled with JetBrains decompiler
// Type: RandomLocalizationKeysData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public sealed class RandomLocalizationKeysData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedStats;

  static RandomLocalizationKeysData()
  {
    Il2CppClassPointerStore<RandomLocalizationKeysData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (RandomLocalizationKeysData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomLocalizationKeysData>.NativeClassPtr);
    RandomLocalizationKeysData.NativeFieldInfoPtr_LocalizedStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomLocalizationKeysData>.NativeClassPtr, nameof (LocalizedStats));
  }

  public RandomLocalizationKeysData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public RandomLocalizationKeysData()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RandomLocalizationKeysData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomLocalizationKeysData>.NativeClassPtr, data));
  }

  public unsafe List<LocalizedStatType> LocalizedStats
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeysData.NativeFieldInfoPtr_LocalizedStats));
      return pointer == System.IntPtr.Zero ? (List<LocalizedStatType>) null : new List<LocalizedStatType>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomLocalizationKeysData.NativeFieldInfoPtr_LocalizedStats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
