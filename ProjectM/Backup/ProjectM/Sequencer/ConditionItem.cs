// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ConditionItem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public sealed class ConditionItem : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardValueType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value2;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionType;

    static ConditionItem()
    {
      Il2CppClassPointerStore<ConditionItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ConditionItem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionItem>.NativeClassPtr);
      ConditionItem.NativeFieldInfoPtr_BlackboardValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionItem>.NativeClassPtr, nameof (BlackboardValueType));
      ConditionItem.NativeFieldInfoPtr_Value1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionItem>.NativeClassPtr, nameof (Value1));
      ConditionItem.NativeFieldInfoPtr_Value2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionItem>.NativeClassPtr, nameof (Value2));
      ConditionItem.NativeFieldInfoPtr_ConditionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionItem>.NativeClassPtr, nameof (ConditionType));
    }

    public ConditionItem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ConditionItem()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConditionItem>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionItem>.NativeClassPtr, data));
    }

    public unsafe BlackboardRegisterType BlackboardValueType
    {
      get
      {
        return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionItem.NativeFieldInfoPtr_BlackboardValueType));
      }
      [param: In] set
      {
        *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionItem.NativeFieldInfoPtr_BlackboardValueType)) = value;
      }
    }

    public BlackboardParameterValue Value1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionItem.NativeFieldInfoPtr_Value1);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionItem.NativeFieldInfoPtr_Value1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public BlackboardParameterValue Value2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionItem.NativeFieldInfoPtr_Value2);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionItem.NativeFieldInfoPtr_Value2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ConditionType ConditionType
    {
      get
      {
        return *(ConditionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionItem.NativeFieldInfoPtr_ConditionType));
      }
      [param: In] set
      {
        *(ConditionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionItem.NativeFieldInfoPtr_ConditionType)) = value;
      }
    }
  }
}
