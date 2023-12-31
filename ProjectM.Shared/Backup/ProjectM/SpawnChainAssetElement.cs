// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainAssetElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class SpawnChainAssetElement : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ElementId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Transitions;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainAssetElement()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainAssetElement>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainAssetElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnChainAssetElement()
    {
      Il2CppClassPointerStore<SpawnChainAssetElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainAssetElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainAssetElement>.NativeClassPtr);
      SpawnChainAssetElement.NativeFieldInfoPtr_ElementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAssetElement>.NativeClassPtr, nameof (ElementId));
      SpawnChainAssetElement.NativeFieldInfoPtr_Transitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAssetElement>.NativeClassPtr, nameof (Transitions));
      SpawnChainAssetElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAssetElement>.NativeClassPtr, 100664474);
    }

    public SpawnChainAssetElement(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string ElementId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.NativeFieldInfoPtr_ElementId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.NativeFieldInfoPtr_ElementId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<SpawnChainAssetElement.ElementTransition> Transitions
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.NativeFieldInfoPtr_Transitions));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpawnChainAssetElement.ElementTransition>) null : new Il2CppReferenceArray<SpawnChainAssetElement.ElementTransition>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.NativeFieldInfoPtr_Transitions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class ElementTransition : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_ElementToSpawnOnTransition;
      private static readonly System.IntPtr NativeFieldInfoPtr_EndOfChainTransition;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ElementTransition()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainAssetElement.ElementTransition>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainAssetElement.ElementTransition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ElementTransition()
      {
        Il2CppClassPointerStore<SpawnChainAssetElement.ElementTransition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainAssetElement>.NativeClassPtr, nameof (ElementTransition));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainAssetElement.ElementTransition>.NativeClassPtr);
        SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_TransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAssetElement.ElementTransition>.NativeClassPtr, nameof (TransitionId));
        SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAssetElement.ElementTransition>.NativeClassPtr, nameof (Importance));
        SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_ElementToSpawnOnTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAssetElement.ElementTransition>.NativeClassPtr, nameof (ElementToSpawnOnTransition));
        SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_EndOfChainTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAssetElement.ElementTransition>.NativeClassPtr, nameof (EndOfChainTransition));
        SpawnChainAssetElement.ElementTransition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAssetElement.ElementTransition>.NativeClassPtr, 100664475);
      }

      public ElementTransition(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SpawnChainTransitionId TransitionId
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_TransitionId));
          return pointer == System.IntPtr.Zero ? (SpawnChainTransitionId) null : new SpawnChainTransitionId(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_TransitionId), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Importance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_Importance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_Importance)) = value;
        }
      }

      public unsafe SpawnChainAssetElement ElementToSpawnOnTransition
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_ElementToSpawnOnTransition));
          return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_ElementToSpawnOnTransition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool EndOfChainTransition
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_EndOfChainTransition));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAssetElement.ElementTransition.NativeFieldInfoPtr_EndOfChainTransition)) = value;
        }
      }
    }
  }
}
