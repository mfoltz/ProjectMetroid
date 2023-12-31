// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class SpawnChainData : Il2CppSystem.Object
  {
    static SpawnChainData()
    {
      Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr);
    }

    public SpawnChainData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ActiveElementsChangedEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChainEntity;
      [FieldOffset(0)]
      public Entity SpawnChainEntity;

      static ActiveElementsChangedEvent()
      {
        Il2CppClassPointerStore<SpawnChainData.ActiveElementsChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr, nameof (ActiveElementsChangedEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData.ActiveElementsChangedEvent>.NativeClassPtr);
        SpawnChainData.ActiveElementsChangedEvent.NativeFieldInfoPtr_SpawnChainEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.ActiveElementsChangedEvent>.NativeClassPtr, nameof (SpawnChainEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainData.ActiveElementsChangedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ActiveChildElement
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ChainElementIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActiveEntity;
      [FieldOffset(0)]
      public int ChainElementIndex;
      [FieldOffset(4)]
      public Entity ActiveEntity;

      static ActiveChildElement()
      {
        Il2CppClassPointerStore<SpawnChainData.ActiveChildElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr, nameof (ActiveChildElement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData.ActiveChildElement>.NativeClassPtr);
        SpawnChainData.ActiveChildElement.NativeFieldInfoPtr_ChainElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.ActiveChildElement>.NativeClassPtr, nameof (ChainElementIndex));
        SpawnChainData.ActiveChildElement.NativeFieldInfoPtr_ActiveEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.ActiveChildElement>.NativeClassPtr, nameof (ActiveEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainData.ActiveChildElement>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnChainConstants
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Data;
      [FieldOffset(0)]
      public BlobAssetReference<SpawnChainBlobAsset> Data;

      static SpawnChainConstants()
      {
        Il2CppClassPointerStore<SpawnChainData.SpawnChainConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr, nameof (SpawnChainConstants));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData.SpawnChainConstants>.NativeClassPtr);
        SpawnChainData.SpawnChainConstants.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.SpawnChainConstants>.NativeClassPtr, nameof (Data));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainData.SpawnChainConstants>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnChainInstance
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LoopOnEndOfChain;
      [FieldOffset(0)]
      public bool LoopOnEndOfChain;

      static SpawnChainInstance()
      {
        Il2CppClassPointerStore<SpawnChainData.SpawnChainInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr, nameof (SpawnChainInstance));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData.SpawnChainInstance>.NativeClassPtr);
        SpawnChainData.SpawnChainInstance.NativeFieldInfoPtr_LoopOnEndOfChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.SpawnChainInstance>.NativeClassPtr, nameof (LoopOnEndOfChain));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainData.SpawnChainInstance>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnChainBlueprint
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BuildingPreviewPrefab;
      [FieldOffset(0)]
      public PrefabGUID BuildingPreviewPrefab;

      static SpawnChainBlueprint()
      {
        Il2CppClassPointerStore<SpawnChainData.SpawnChainBlueprint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr, nameof (SpawnChainBlueprint));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData.SpawnChainBlueprint>.NativeClassPtr);
        SpawnChainData.SpawnChainBlueprint.NativeFieldInfoPtr_BuildingPreviewPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.SpawnChainBlueprint>.NativeClassPtr, nameof (BuildingPreviewPrefab));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainData.SpawnChainBlueprint>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct QueuedTransitionRequests
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Request;
      [FieldOffset(0)]
      public SpawnChainTransitionEvent Request;

      static QueuedTransitionRequests()
      {
        Il2CppClassPointerStore<SpawnChainData.QueuedTransitionRequests>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr, nameof (QueuedTransitionRequests));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData.QueuedTransitionRequests>.NativeClassPtr);
        SpawnChainData.QueuedTransitionRequests.NativeFieldInfoPtr_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.QueuedTransitionRequests>.NativeClassPtr, nameof (Request));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainData.QueuedTransitionRequests>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ElementName
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ActualName;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxLength_Public_Static_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ElementName_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Public_Static_Boolean_SpawnChainAssetElement_byref_ElementName_0;
      [FieldOffset(0)]
      public FixedString32 ActualName;

      public static unsafe int MaxLength
      {
        [CallerCount(3), CachedScanResults(RefRangeStart = 728496, RefRangeEnd = 728499, XrefRangeStart = 728495, XrefRangeEnd = 728496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.ElementName.NativeMethodInfoPtr_get_MaxLength_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 728500, RefRangeEnd = 728507, XrefRangeStart = 728499, XrefRangeEnd = 728500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ElementName(string actualName)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(actualName);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainData.ElementName.NativeMethodInfoPtr__ctor_Public_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 728508, RefRangeEnd = 728512, XrefRangeStart = 728507, XrefRangeEnd = 728508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(SpawnChainData.ElementName other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.ElementName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ElementName_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 728513, RefRangeEnd = 728515, XrefRangeStart = 728512, XrefRangeEnd = 728513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.ElementName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728515, XrefRangeEnd = 728516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.ElementName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728516, XrefRangeEnd = 728519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.ElementName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 728525, RefRangeEnd = 728526, XrefRangeStart = 728519, XrefRangeEnd = 728525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryConvert(
        SpawnChainAssetElement element,
        out SpawnChainData.ElementName convertedName)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) element);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref convertedName;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.ElementName.NativeMethodInfoPtr_TryConvert_Public_Static_Boolean_SpawnChainAssetElement_byref_ElementName_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ElementName()
      {
        Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr, nameof (ElementName));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr);
        SpawnChainData.ElementName.NativeFieldInfoPtr_ActualName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, nameof (ActualName));
        SpawnChainData.ElementName.NativeMethodInfoPtr_get_MaxLength_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, 100664494);
        SpawnChainData.ElementName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, 100664495);
        SpawnChainData.ElementName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ElementName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, 100664496);
        SpawnChainData.ElementName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, 100664497);
        SpawnChainData.ElementName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, 100664498);
        SpawnChainData.ElementName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, 100664499);
        SpawnChainData.ElementName.NativeMethodInfoPtr_TryConvert_Public_Static_Boolean_SpawnChainAssetElement_byref_ElementName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, 100664500);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainData.ElementName>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TransitionId
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ActualId;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxLength_Public_Static_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FixedString32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Public_Static_Boolean_SpawnChainTransitionId_byref_TransitionId_0;
      [FieldOffset(0)]
      public FixedString32 ActualId;

      public static unsafe int MaxLength
      {
        [CallerCount(3), CachedScanResults(RefRangeStart = 728496, RefRangeEnd = 728499, XrefRangeStart = 728496, XrefRangeEnd = 728499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.TransitionId.NativeMethodInfoPtr_get_MaxLength_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 728500, RefRangeEnd = 728507, XrefRangeStart = 728500, XrefRangeEnd = 728507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TransitionId(string transitionId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(transitionId);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainData.TransitionId.NativeMethodInfoPtr__ctor_Public_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 254299, RefRangeEnd = 254311, XrefRangeStart = 254299, XrefRangeEnd = 254311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TransitionId(FixedString32 transitionId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &transitionId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainData.TransitionId.NativeMethodInfoPtr__ctor_Public_Void_FixedString32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 728508, RefRangeEnd = 728512, XrefRangeStart = 728508, XrefRangeEnd = 728512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(SpawnChainData.TransitionId other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.TransitionId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 728513, RefRangeEnd = 728515, XrefRangeStart = 728513, XrefRangeEnd = 728515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.TransitionId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.TransitionId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728526, XrefRangeEnd = 728529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.TransitionId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 728535, RefRangeEnd = 728539, XrefRangeStart = 728529, XrefRangeEnd = 728535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryConvert(
        SpawnChainTransitionId transitionId,
        out SpawnChainData.TransitionId convertedId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transitionId);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref convertedId;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainData.TransitionId.NativeMethodInfoPtr_TryConvert_Public_Static_Boolean_SpawnChainTransitionId_byref_TransitionId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TransitionId()
      {
        Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainData>.NativeClassPtr, nameof (TransitionId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr);
        SpawnChainData.TransitionId.NativeFieldInfoPtr_ActualId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, nameof (ActualId));
        SpawnChainData.TransitionId.NativeMethodInfoPtr_get_MaxLength_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, 100664501);
        SpawnChainData.TransitionId.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, 100664502);
        SpawnChainData.TransitionId.NativeMethodInfoPtr__ctor_Public_Void_FixedString32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, 100664503);
        SpawnChainData.TransitionId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, 100664504);
        SpawnChainData.TransitionId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, 100664505);
        SpawnChainData.TransitionId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, 100664506);
        SpawnChainData.TransitionId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, 100664507);
        SpawnChainData.TransitionId.NativeMethodInfoPtr_TryConvert_Public_Static_Boolean_SpawnChainTransitionId_byref_TransitionId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, 100664508);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainData.TransitionId>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
