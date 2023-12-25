// Decompiled with JetBrains decompiler
// Type: ProjectM.UISequenceMapping
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class UISequenceMapping : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sequences;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077710, XrefRangeEnd = 1077726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UISequenceMapping.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077726, XrefRangeEnd = 1077735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UISequenceMapping()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISequenceMapping>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UISequenceMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UISequenceMapping()
    {
      Il2CppClassPointerStore<UISequenceMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UISequenceMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISequenceMapping>.NativeClassPtr);
      UISequenceMapping.NativeFieldInfoPtr_Sequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequenceMapping>.NativeClassPtr, nameof (Sequences));
      UISequenceMapping.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISequenceMapping>.NativeClassPtr, 100684870);
      UISequenceMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISequenceMapping>.NativeClassPtr, 100684871);
    }

    public UISequenceMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<UISequenceMapping.UISequence> Sequences
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequenceMapping.NativeFieldInfoPtr_Sequences));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<UISequenceMapping.UISequence>) null : new Il2CppReferenceArray<UISequenceMapping.UISequence>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISequenceMapping.NativeFieldInfoPtr_Sequences), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class UISequence : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_Sequence;

      static UISequence()
      {
        Il2CppClassPointerStore<UISequenceMapping.UISequence>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISequenceMapping>.NativeClassPtr, nameof (UISequence));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISequenceMapping.UISequence>.NativeClassPtr);
        UISequenceMapping.UISequence.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequenceMapping.UISequence>.NativeClassPtr, nameof (Type));
        UISequenceMapping.UISequence.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequenceMapping.UISequence>.NativeClassPtr, nameof (Sequence));
      }

      public UISequence(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public UISequence()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UISequenceMapping.UISequence>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UISequenceMapping.UISequence>.NativeClassPtr, data));
      }

      public unsafe UISequenceType Type
      {
        get
        {
          return *(UISequenceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequenceMapping.UISequence.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(UISequenceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequenceMapping.UISequence.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public unsafe SequenceEditorObject Sequence
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequenceMapping.UISequence.NativeFieldInfoPtr_Sequence));
          return pointer == System.IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISequenceMapping.UISequence.NativeFieldInfoPtr_Sequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
