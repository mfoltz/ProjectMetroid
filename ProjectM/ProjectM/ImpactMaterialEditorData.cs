// Decompiled with JetBrains decompiler
// Type: ProjectM.ImpactMaterialEditorData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class ImpactMaterialEditorData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sequence;

    static ImpactMaterialEditorData()
    {
      Il2CppClassPointerStore<ImpactMaterialEditorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ImpactMaterialEditorData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactMaterialEditorData>.NativeClassPtr);
      ImpactMaterialEditorData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterialEditorData>.NativeClassPtr, nameof (Type));
      ImpactMaterialEditorData.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterialEditorData>.NativeClassPtr, nameof (Sequence));
    }

    public ImpactMaterialEditorData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ImpactMaterialEditorData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ImpactMaterialEditorData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImpactMaterialEditorData>.NativeClassPtr, data));
    }

    public unsafe ImpactMaterialType Type
    {
      get
      {
        return *(ImpactMaterialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialEditorData.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(ImpactMaterialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialEditorData.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe SequenceField Sequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialEditorData.NativeFieldInfoPtr_Sequence));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialEditorData.NativeFieldInfoPtr_Sequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
