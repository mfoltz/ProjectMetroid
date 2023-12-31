// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroRangeAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class AggroRangeAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Cone;
    private static readonly System.IntPtr NativeFieldInfoPtr_Circle;
    private static readonly System.IntPtr NativeFieldInfoPtr_NightFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToRuntimeFormat_Public_AggroData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe AggroData ToRuntimeFormat()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroRangeAsset.NativeMethodInfoPtr_ToRuntimeFormat_Public_AggroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AggroData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723018, XrefRangeEnd = 723019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AggroRangeAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroRangeAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AggroRangeAsset()
    {
      Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroRangeAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr);
      AggroRangeAsset.NativeFieldInfoPtr_Cone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr, nameof (Cone));
      AggroRangeAsset.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr, nameof (Circle));
      AggroRangeAsset.NativeFieldInfoPtr_NightFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr, nameof (NightFactor));
      AggroRangeAsset.NativeFieldInfoPtr_AggroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr, nameof (AggroValue));
      AggroRangeAsset.NativeMethodInfoPtr_ToRuntimeFormat_Public_AggroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr, 100663877);
      AggroRangeAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr, 100663878);
    }

    public AggroRangeAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AggroRangeAsset.ConeData Cone
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.NativeFieldInfoPtr_Cone));
        return pointer == System.IntPtr.Zero ? (AggroRangeAsset.ConeData) null : new AggroRangeAsset.ConeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.NativeFieldInfoPtr_Cone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AggroRangeAsset.CircleData Circle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.NativeFieldInfoPtr_Circle));
        return pointer == System.IntPtr.Zero ? (AggroRangeAsset.CircleData) null : new AggroRangeAsset.CircleData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float NightFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.NativeFieldInfoPtr_NightFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.NativeFieldInfoPtr_NightFactor)) = value;
      }
    }

    public unsafe float AggroValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.NativeFieldInfoPtr_AggroValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.NativeFieldInfoPtr_AggroValue)) = value;
      }
    }

    [Serializable]
    public class ConeData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
      private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ConeData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroRangeAsset.ConeData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroRangeAsset.ConeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ConeData()
      {
        Il2CppClassPointerStore<AggroRangeAsset.ConeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr, nameof (ConeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroRangeAsset.ConeData>.NativeClassPtr);
        AggroRangeAsset.ConeData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroRangeAsset.ConeData>.NativeClassPtr, nameof (Radius));
        AggroRangeAsset.ConeData.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroRangeAsset.ConeData>.NativeClassPtr, nameof (Angle));
        AggroRangeAsset.ConeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroRangeAsset.ConeData>.NativeClassPtr, 100663879);
      }

      public ConeData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe float Radius
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.ConeData.NativeFieldInfoPtr_Radius));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.ConeData.NativeFieldInfoPtr_Radius)) = value;
        }
      }

      public unsafe float Angle
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.ConeData.NativeFieldInfoPtr_Angle));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.ConeData.NativeFieldInfoPtr_Angle)) = value;
        }
      }
    }

    [Serializable]
    public class CircleData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CircleData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroRangeAsset.CircleData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroRangeAsset.CircleData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CircleData()
      {
        Il2CppClassPointerStore<AggroRangeAsset.CircleData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroRangeAsset>.NativeClassPtr, nameof (CircleData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroRangeAsset.CircleData>.NativeClassPtr);
        AggroRangeAsset.CircleData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroRangeAsset.CircleData>.NativeClassPtr, nameof (Radius));
        AggroRangeAsset.CircleData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroRangeAsset.CircleData>.NativeClassPtr, 100663880);
      }

      public CircleData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe float Radius
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.CircleData.NativeFieldInfoPtr_Radius));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroRangeAsset.CircleData.NativeFieldInfoPtr_Radius)) = value;
        }
      }
    }
  }
}
