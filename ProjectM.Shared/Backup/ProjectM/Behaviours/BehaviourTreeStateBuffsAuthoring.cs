// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeStateBuffsAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Behaviours
{
  public class BehaviourTreeStateBuffsAuthoring : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entries;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790009, XrefRangeEnd = 790024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeStateBuffsAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BehaviourTreeStateBuffsAuthoring()
    {
      Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Behaviours", nameof (BehaviourTreeStateBuffsAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring>.NativeClassPtr);
      BehaviourTreeStateBuffsAuthoring.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring>.NativeClassPtr, nameof (Entries));
      BehaviourTreeStateBuffsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring>.NativeClassPtr, 100669512);
      BehaviourTreeStateBuffsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring>.NativeClassPtr, 100669513);
    }

    public BehaviourTreeStateBuffsAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<BehaviourTreeStateBuffsAuthoring.Entry> Entries
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsAuthoring.NativeFieldInfoPtr_Entries));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BehaviourTreeStateBuffsAuthoring.Entry>) null : new Il2CppReferenceArray<BehaviourTreeStateBuffsAuthoring.Entry>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsAuthoring.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class Entry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_State;
      private static readonly System.IntPtr NativeFieldInfoPtr_Buff;

      static Entry()
      {
        Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring>.NativeClassPtr, nameof (Entry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring.Entry>.NativeClassPtr);
        BehaviourTreeStateBuffsAuthoring.Entry.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring.Entry>.NativeClassPtr, nameof (State));
        BehaviourTreeStateBuffsAuthoring.Entry.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring.Entry>.NativeClassPtr, nameof (Buff));
      }

      public Entry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Entry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring.Entry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsAuthoring.Entry>.NativeClassPtr, data));
      }

      public unsafe GenericEnemyState State
      {
        get
        {
          return *(GenericEnemyState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsAuthoring.Entry.NativeFieldInfoPtr_State));
        }
        [param: In] set
        {
          *(GenericEnemyState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsAuthoring.Entry.NativeFieldInfoPtr_State)) = value;
        }
      }

      public unsafe PrefabGuidComponent Buff
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsAuthoring.Entry.NativeFieldInfoPtr_Buff));
          return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsAuthoring.Entry.NativeFieldInfoPtr_Buff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
