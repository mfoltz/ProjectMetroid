// Decompiled with JetBrains decompiler
// Type: ProjectM.AlertRangeAsset
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
  public class AlertRangeAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Cone;
    private static readonly System.IntPtr NativeFieldInfoPtr_Circle;
    private static readonly System.IntPtr NativeFieldInfoPtr_NightFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlertValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToRuntimeFormat_Public_AggroData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe AggroData ToRuntimeFormat()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertRangeAsset.NativeMethodInfoPtr_ToRuntimeFormat_Public_AggroData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AggroData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AlertRangeAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AlertRangeAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AlertRangeAsset()
    {
      Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AlertRangeAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr);
      AlertRangeAsset.NativeFieldInfoPtr_Cone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr, nameof (Cone));
      AlertRangeAsset.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr, nameof (Circle));
      AlertRangeAsset.NativeFieldInfoPtr_NightFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr, nameof (NightFactor));
      AlertRangeAsset.NativeFieldInfoPtr_AlertValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr, nameof (AlertValue));
      AlertRangeAsset.NativeMethodInfoPtr_ToRuntimeFormat_Public_AggroData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr, 100663888);
      AlertRangeAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr, 100663889);
    }

    public AlertRangeAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AlertRangeAsset.ConeData Cone
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.NativeFieldInfoPtr_Cone));
        return pointer == System.IntPtr.Zero ? (AlertRangeAsset.ConeData) null : new AlertRangeAsset.ConeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.NativeFieldInfoPtr_Cone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AlertRangeAsset.CircleData Circle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.NativeFieldInfoPtr_Circle));
        return pointer == System.IntPtr.Zero ? (AlertRangeAsset.CircleData) null : new AlertRangeAsset.CircleData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float NightFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.NativeFieldInfoPtr_NightFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.NativeFieldInfoPtr_NightFactor)) = value;
      }
    }

    public unsafe float AlertValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.NativeFieldInfoPtr_AlertValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.NativeFieldInfoPtr_AlertValue)) = value;
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
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlertRangeAsset.ConeData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertRangeAsset.ConeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ConeData()
      {
        Il2CppClassPointerStore<AlertRangeAsset.ConeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr, nameof (ConeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertRangeAsset.ConeData>.NativeClassPtr);
        AlertRangeAsset.ConeData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertRangeAsset.ConeData>.NativeClassPtr, nameof (Radius));
        AlertRangeAsset.ConeData.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertRangeAsset.ConeData>.NativeClassPtr, nameof (Angle));
        AlertRangeAsset.ConeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertRangeAsset.ConeData>.NativeClassPtr, 100663890);
      }

      public ConeData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe float Radius
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.ConeData.NativeFieldInfoPtr_Radius));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.ConeData.NativeFieldInfoPtr_Radius)) = value;
        }
      }

      public unsafe float Angle
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.ConeData.NativeFieldInfoPtr_Angle));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.ConeData.NativeFieldInfoPtr_Angle)) = value;
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
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlertRangeAsset.CircleData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertRangeAsset.CircleData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CircleData()
      {
        Il2CppClassPointerStore<AlertRangeAsset.CircleData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertRangeAsset>.NativeClassPtr, nameof (CircleData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertRangeAsset.CircleData>.NativeClassPtr);
        AlertRangeAsset.CircleData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertRangeAsset.CircleData>.NativeClassPtr, nameof (Radius));
        AlertRangeAsset.CircleData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertRangeAsset.CircleData>.NativeClassPtr, 100663891);
      }

      public CircleData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe float Radius
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.CircleData.NativeFieldInfoPtr_Radius));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertRangeAsset.CircleData.NativeFieldInfoPtr_Radius)) = value;
        }
      }
    }
  }
}
