// Decompiled with JetBrains decompiler
// Type: SplineModuleCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SplineModuleCollection : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ScaleAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_MinMaxScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_HasValidScaleDir;
  private static readonly System.IntPtr NativeFieldInfoPtr_AllowedRotationInConstrained;
  private static readonly System.IntPtr NativeFieldInfoPtr_KeepYUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_Modules;
  private static readonly System.IntPtr NativeFieldInfoPtr_EndModules;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714248, XrefRangeEnd = 714249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SplineModuleCollection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplineModuleCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SplineModuleCollection()
  {
    Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (SplineModuleCollection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr);
    SplineModuleCollection.NativeFieldInfoPtr_ScaleAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (ScaleAxis));
    SplineModuleCollection.NativeFieldInfoPtr_MinMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (MinMaxScale));
    SplineModuleCollection.NativeFieldInfoPtr_HasValidScaleDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (HasValidScaleDir));
    SplineModuleCollection.NativeFieldInfoPtr_AllowedRotationInConstrained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (AllowedRotationInConstrained));
    SplineModuleCollection.NativeFieldInfoPtr_KeepYUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (KeepYUp));
    SplineModuleCollection.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (Modules));
    SplineModuleCollection.NativeFieldInfoPtr_EndModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (EndModules));
    SplineModuleCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, 100663333);
  }

  public SplineModuleCollection(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector3 ScaleAxis
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_ScaleAxis));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_ScaleAxis)) = value;
    }
  }

  public unsafe Vector2 MinMaxScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_MinMaxScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_MinMaxScale)) = value;
    }
  }

  public unsafe bool HasValidScaleDir
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_HasValidScaleDir));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_HasValidScaleDir)) = value;
    }
  }

  public unsafe float AllowedRotationInConstrained
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_AllowedRotationInConstrained));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_AllowedRotationInConstrained)) = value;
    }
  }

  public unsafe bool KeepYUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_KeepYUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_KeepYUp)) = value;
    }
  }

  public unsafe List<SplineModuleCollection.SplineModule> Modules
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_Modules));
      return pointer == System.IntPtr.Zero ? (List<SplineModuleCollection.SplineModule>) null : new List<SplineModuleCollection.SplineModule>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<SplineModuleCollection.SplineModule> EndModules
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_EndModules));
      return pointer == System.IntPtr.Zero ? (List<SplineModuleCollection.SplineModule>) null : new List<SplineModuleCollection.SplineModule>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.NativeFieldInfoPtr_EndModules), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class SplineModuleAttachment : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SplineModuleAttachment()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplineModuleCollection.SplineModuleAttachment>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplineModuleCollection.SplineModuleAttachment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SplineModuleAttachment()
    {
      Il2CppClassPointerStore<SplineModuleCollection.SplineModuleAttachment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (SplineModuleAttachment));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineModuleCollection.SplineModuleAttachment>.NativeClassPtr);
      SplineModuleCollection.SplineModuleAttachment.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModuleAttachment>.NativeClassPtr, nameof (Position));
      SplineModuleCollection.SplineModuleAttachment.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModuleAttachment>.NativeClassPtr, nameof (Direction));
      SplineModuleCollection.SplineModuleAttachment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineModuleCollection.SplineModuleAttachment>.NativeClassPtr, 100663334);
    }

    public SplineModuleAttachment(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 Position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModuleAttachment.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModuleAttachment.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe Vector3 Direction
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModuleAttachment.NativeFieldInfoPtr_Direction));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModuleAttachment.NativeFieldInfoPtr_Direction)) = value;
      }
    }
  }

  [Serializable]
  public class SplineModule : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModuleMesh;
    private static readonly System.IntPtr NativeFieldInfoPtr_InAttachments;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutAttachments;
    private static readonly System.IntPtr NativeFieldInfoPtr_MidPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_Length;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConstrainRotationX;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConstrainRotationY;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConstrainRotationZ;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SplineModule()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplineModuleCollection.SplineModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SplineModule()
    {
      Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplineModuleCollection>.NativeClassPtr, nameof (SplineModule));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr);
      SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ModuleMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, nameof (ModuleMesh));
      SplineModuleCollection.SplineModule.NativeFieldInfoPtr_InAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, nameof (InAttachments));
      SplineModuleCollection.SplineModule.NativeFieldInfoPtr_OutAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, nameof (OutAttachments));
      SplineModuleCollection.SplineModule.NativeFieldInfoPtr_MidPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, nameof (MidPoint));
      SplineModuleCollection.SplineModule.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, nameof (Length));
      SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, nameof (ConstrainRotationX));
      SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, nameof (ConstrainRotationY));
      SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, nameof (ConstrainRotationZ));
      SplineModuleCollection.SplineModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineModuleCollection.SplineModule>.NativeClassPtr, 100663335);
    }

    public SplineModule(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject ModuleMesh
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ModuleMesh));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ModuleMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SplineModuleCollection.SplineModuleAttachment> InAttachments
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_InAttachments));
        return pointer == System.IntPtr.Zero ? (List<SplineModuleCollection.SplineModuleAttachment>) null : new List<SplineModuleCollection.SplineModuleAttachment>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_InAttachments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SplineModuleCollection.SplineModuleAttachment> OutAttachments
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_OutAttachments));
        return pointer == System.IntPtr.Zero ? (List<SplineModuleCollection.SplineModuleAttachment>) null : new List<SplineModuleCollection.SplineModuleAttachment>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_OutAttachments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 MidPoint
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_MidPoint));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_MidPoint)) = value;
      }
    }

    public unsafe float Length
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_Length));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_Length)) = value;
      }
    }

    public unsafe bool ConstrainRotationX
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationX));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationX)) = value;
      }
    }

    public unsafe bool ConstrainRotationY
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationY));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationY)) = value;
      }
    }

    public unsafe bool ConstrainRotationZ
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationZ));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineModuleCollection.SplineModule.NativeFieldInfoPtr_ConstrainRotationZ)) = value;
      }
    }
  }
}
