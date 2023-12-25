// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.Stunlock_Sequencer_SequenceAssetReferences_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Sequencer;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class Stunlock_Sequencer_SequenceAssetReferences_PropertyBag : 
    ContainerPropertyBag<SequenceAssetReferences>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1169748, RefRangeEnd = 1169749, XrefRangeStart = 1169732, XrefRangeEnd = 1169748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Stunlock_Sequencer_SequenceAssetReferences_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Stunlock_Sequencer_SequenceAssetReferences_PropertyBag()
    {
      Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (Stunlock_Sequencer_SequenceAssetReferences_PropertyBag));
      Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag>.NativeClassPtr, 100692773);
    }

    public Stunlock_Sequencer_SequenceAssetReferences_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Objects_Property : Property<SequenceAssetReferences, List<UnityEngine.Object>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_Object_byref_SequenceAssetReferences_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SequenceAssetReferences_List_1_Object_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169726, XrefRangeEnd = 1169728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169731, RefRangeEnd = 1169732, XrefRangeStart = 1169728, XrefRangeEnd = 1169731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Objects_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe List<UnityEngine.Object> GetValue(ref SequenceAssetReferences container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_Object_byref_SequenceAssetReferences_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SequenceAssetReferences local = ref container;
        IntPtr pointer1 = ptr;
        SequenceAssetReferences sequenceAssetReferences = pointer1 == IntPtr.Zero ? (SequenceAssetReferences) null : new SequenceAssetReferences(pointer1);
        local = sequenceAssetReferences;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (List<UnityEngine.Object>) null : new List<UnityEngine.Object>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref SequenceAssetReferences container,
        List<UnityEngine.Object> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SequenceAssetReferences_List_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref SequenceAssetReferences local = ref container;
        IntPtr pointer = ptr;
        SequenceAssetReferences sequenceAssetReferences = pointer == IntPtr.Zero ? (SequenceAssetReferences) null : new SequenceAssetReferences(pointer);
        local = sequenceAssetReferences;
      }

      static Objects_Property()
      {
        Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag>.NativeClassPtr, nameof (Objects_Property));
        Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property>.NativeClassPtr, 100692774);
        Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property>.NativeClassPtr, 100692775);
        Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property>.NativeClassPtr, 100692776);
        Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_Object_byref_SequenceAssetReferences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property>.NativeClassPtr, 100692777);
        Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SequenceAssetReferences_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Sequencer_SequenceAssetReferences_PropertyBag.Objects_Property>.NativeClassPtr, 100692778);
      }

      public Objects_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
