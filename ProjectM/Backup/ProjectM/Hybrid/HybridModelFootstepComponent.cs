// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelFootstepComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Audio;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridModelFootstepComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__FootstepSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FootstepHardCutoffDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FootstepCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFootstepTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__StopPlayingOnDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideCharFootstep;
    private static readonly System.IntPtr NativeFieldInfoPtr_FootstepEvents;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFootstep_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157416, XrefRangeEnd = 1157424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hybridEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelFootstepComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1157440, RefRangeEnd = 1157442, XrefRangeStart = 1157424, XrefRangeEnd = 1157440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnFootstep(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelFootstepComponent.NativeMethodInfoPtr_OnFootstep_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157442, XrefRangeEnd = 1157443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelFootstepComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelFootstepComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelFootstepComponent()
    {
      Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelFootstepComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr);
      HybridModelFootstepComponent.NativeFieldInfoPtr__FootstepSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (_FootstepSystem));
      HybridModelFootstepComponent.NativeFieldInfoPtr__Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (_Entity));
      HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepHardCutoffDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (FootstepHardCutoffDistance));
      HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (FootstepCooldown));
      HybridModelFootstepComponent.NativeFieldInfoPtr__LastFootstepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (_LastFootstepTime));
      HybridModelFootstepComponent.NativeFieldInfoPtr__StopPlayingOnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (_StopPlayingOnDeath));
      HybridModelFootstepComponent.NativeFieldInfoPtr_OverrideCharFootstep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (OverrideCharFootstep));
      HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (FootstepEvents));
      HybridModelFootstepComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, 100692135);
      HybridModelFootstepComponent.NativeMethodInfoPtr_OnFootstep_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, 100692136);
      HybridModelFootstepComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, 100692137);
    }

    public HybridModelFootstepComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FootstepSystem _FootstepSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr__FootstepSystem));
        return pointer == System.IntPtr.Zero ? (FootstepSystem) null : new FootstepSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr__FootstepSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _Entity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr__Entity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr__Entity)) = value;
      }
    }

    public unsafe float FootstepHardCutoffDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepHardCutoffDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepHardCutoffDistance)) = value;
      }
    }

    public unsafe float FootstepCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepCooldown)) = value;
      }
    }

    public unsafe float _LastFootstepTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr__LastFootstepTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr__LastFootstepTime)) = value;
      }
    }

    public unsafe bool _StopPlayingOnDeath
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr__StopPlayingOnDeath));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr__StopPlayingOnDeath)) = value;
      }
    }

    public unsafe bool OverrideCharFootstep
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr_OverrideCharFootstep));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr_OverrideCharFootstep)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<HybridModelFootstepComponent.FootstepEntry> FootstepEvents
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepEvents));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridModelFootstepComponent.FootstepEntry>) null : new Il2CppReferenceArray<HybridModelFootstepComponent.FootstepEntry>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.NativeFieldInfoPtr_FootstepEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class FootstepEntry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Event;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayWhenNotMoving;

      static FootstepEntry()
      {
        Il2CppClassPointerStore<HybridModelFootstepComponent.FootstepEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelFootstepComponent>.NativeClassPtr, nameof (FootstepEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelFootstepComponent.FootstepEntry>.NativeClassPtr);
        HybridModelFootstepComponent.FootstepEntry.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent.FootstepEntry>.NativeClassPtr, nameof (Event));
        HybridModelFootstepComponent.FootstepEntry.NativeFieldInfoPtr_PlayWhenNotMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelFootstepComponent.FootstepEntry>.NativeClassPtr, nameof (PlayWhenNotMoving));
      }

      public FootstepEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public FootstepEntry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridModelFootstepComponent.FootstepEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelFootstepComponent.FootstepEntry>.NativeClassPtr, data));
      }

      public FmodEvent Event
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.FootstepEntry.NativeFieldInfoPtr_Event);
          return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.FootstepEntry.NativeFieldInfoPtr_Event), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool PlayWhenNotMoving
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.FootstepEntry.NativeFieldInfoPtr_PlayWhenNotMoving));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelFootstepComponent.FootstepEntry.NativeFieldInfoPtr_PlayWhenNotMoving)) = value;
        }
      }
    }
  }
}
