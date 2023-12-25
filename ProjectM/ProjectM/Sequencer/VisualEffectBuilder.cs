// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.VisualEffectBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Sequencer
{
  public sealed class VisualEffectBuilder : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Parameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardValueType;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffectIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterName;

    static VisualEffectBuilder()
    {
      Il2CppClassPointerStore<VisualEffectBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (VisualEffectBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectBuilder>.NativeClassPtr);
      VisualEffectBuilder.NativeFieldInfoPtr_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectBuilder>.NativeClassPtr, nameof (Parameter));
      VisualEffectBuilder.NativeFieldInfoPtr_BlackboardValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectBuilder>.NativeClassPtr, nameof (BlackboardValueType));
      VisualEffectBuilder.NativeFieldInfoPtr_VisualEffectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectBuilder>.NativeClassPtr, nameof (VisualEffectIndex));
      VisualEffectBuilder.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectBuilder>.NativeClassPtr, nameof (ParameterName));
    }

    public VisualEffectBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public VisualEffectBuilder()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VisualEffectBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualEffectBuilder>.NativeClassPtr, data));
    }

    public BlackboardParameterBuilder Parameter
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectBuilder.NativeFieldInfoPtr_Parameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectBuilder.NativeFieldInfoPtr_Parameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BlackboardRegisterType BlackboardValueType
    {
      get
      {
        return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectBuilder.NativeFieldInfoPtr_BlackboardValueType));
      }
      [param: In] set
      {
        *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectBuilder.NativeFieldInfoPtr_BlackboardValueType)) = value;
      }
    }

    public unsafe int VisualEffectIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectBuilder.NativeFieldInfoPtr_VisualEffectIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectBuilder.NativeFieldInfoPtr_VisualEffectIndex)) = value;
      }
    }

    public unsafe FixedString64 ParameterName
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectBuilder.NativeFieldInfoPtr_ParameterName));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectBuilder.NativeFieldInfoPtr_ParameterName)) = value;
      }
    }
  }
}
