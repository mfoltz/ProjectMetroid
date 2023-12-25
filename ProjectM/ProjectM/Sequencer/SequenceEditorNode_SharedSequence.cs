// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_SharedSequence
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorNode_SharedSequence : SequenceEditorNode
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SharedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr__BlackboardMappings;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SharedSequence_Public_get_SequenceEditorObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BlackboardMappings_Public_get_List_1_BlackboardMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_BlackboardMappings_Public_set_Void_List_1_BlackboardMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe SequenceEditorObject SharedSequence
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_get_SharedSequence_Public_get_SequenceEditorObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
      }
    }

    public unsafe List<SequenceEditorNode_SharedSequence.BlackboardMapping> BlackboardMappings
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22439, RefRangeEnd = 22440, XrefRangeStart = 22439, XrefRangeEnd = 22440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_get_BlackboardMappings_Public_get_List_1_BlackboardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<SequenceEditorNode_SharedSequence.BlackboardMapping>) null : new List<SequenceEditorNode_SharedSequence.BlackboardMapping>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_set_BlackboardMappings_Public_set_Void_List_1_BlackboardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public override unsafe string ExtendedName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093744, XrefRangeEnd = 1093748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public override unsafe string IconClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093748, XrefRangeEnd = 1093750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    public override unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093750, XrefRangeEnd = 1093768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeStatus GetNodeStatus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093768, XrefRangeEnd = 1093779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_SharedSequence()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_SharedSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_SharedSequence()
    {
      Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_SharedSequence));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr);
      SequenceEditorNode_SharedSequence.NativeFieldInfoPtr__SharedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, nameof (_SharedSequence));
      SequenceEditorNode_SharedSequence.NativeFieldInfoPtr__BlackboardMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, nameof (_BlackboardMappings));
      SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_get_SharedSequence_Public_get_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, 100686538);
      SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_get_BlackboardMappings_Public_get_List_1_BlackboardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, 100686539);
      SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_set_BlackboardMappings_Public_set_Void_List_1_BlackboardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, 100686540);
      SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, 100686541);
      SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, 100686542);
      SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, 100686543);
      SequenceEditorNode_SharedSequence.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, 100686544);
      SequenceEditorNode_SharedSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, 100686545);
    }

    public SequenceEditorNode_SharedSequence(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceEditorObject _SharedSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.NativeFieldInfoPtr__SharedSequence));
        return pointer == System.IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.NativeFieldInfoPtr__SharedSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SequenceEditorNode_SharedSequence.BlackboardMapping> _BlackboardMappings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.NativeFieldInfoPtr__BlackboardMappings));
        return pointer == System.IntPtr.Zero ? (List<SequenceEditorNode_SharedSequence.BlackboardMapping>) null : new List<SequenceEditorNode_SharedSequence.BlackboardMapping>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.NativeFieldInfoPtr__BlackboardMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class BlackboardMapping : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_VisualName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Guid;

      static BlackboardMapping()
      {
        Il2CppClassPointerStore<SequenceEditorNode_SharedSequence.BlackboardMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence>.NativeClassPtr, nameof (BlackboardMapping));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence.BlackboardMapping>.NativeClassPtr);
        SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence.BlackboardMapping>.NativeClassPtr, nameof (Type));
        SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence.BlackboardMapping>.NativeClassPtr, nameof (Value));
        SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_VisualName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence.BlackboardMapping>.NativeClassPtr, nameof (VisualName));
        SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence.BlackboardMapping>.NativeClassPtr, nameof (Guid));
      }

      public BlackboardMapping(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BlackboardMapping()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence.BlackboardMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequenceEditorNode_SharedSequence.BlackboardMapping>.NativeClassPtr, data));
      }

      public unsafe BlackboardRegisterType Type
      {
        get
        {
          return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public BlackboardParameterValue Value
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Value);
          return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe string VisualName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_VisualName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_VisualName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Guid
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Guid)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_SharedSequence.BlackboardMapping.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }
}
