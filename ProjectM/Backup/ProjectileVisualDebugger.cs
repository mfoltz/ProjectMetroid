// Decompiled with JetBrains decompiler
// Type: ProjectileVisualDebugger
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ProjectileVisualDebugger : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_IsActive;
  private static readonly IntPtr NativeFieldInfoPtr__WasActive;
  private static readonly IntPtr NativeFieldInfoPtr_MoveTransform;
  private static readonly IntPtr NativeFieldInfoPtr_UseWorldZero;
  private static readonly IntPtr NativeFieldInfoPtr_Movement;
  private static readonly IntPtr NativeFieldInfoPtr_Distance;
  private static readonly IntPtr NativeFieldInfoPtr_Speed;
  private static readonly IntPtr NativeFieldInfoPtr_Direction;
  private static readonly IntPtr NativeFieldInfoPtr__OriginalPosition;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921593, XrefRangeEnd = 921613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ProjectileVisualDebugger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921613, XrefRangeEnd = 921614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProjectileVisualDebugger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ProjectileVisualDebugger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ProjectileVisualDebugger()
  {
    Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ProjectileVisualDebugger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr);
    ProjectileVisualDebugger.NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (IsActive));
    ProjectileVisualDebugger.NativeFieldInfoPtr__WasActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (_WasActive));
    ProjectileVisualDebugger.NativeFieldInfoPtr_MoveTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (MoveTransform));
    ProjectileVisualDebugger.NativeFieldInfoPtr_UseWorldZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (UseWorldZero));
    ProjectileVisualDebugger.NativeFieldInfoPtr_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (Movement));
    ProjectileVisualDebugger.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (Distance));
    ProjectileVisualDebugger.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (Speed));
    ProjectileVisualDebugger.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (Direction));
    ProjectileVisualDebugger.NativeFieldInfoPtr__OriginalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, nameof (_OriginalPosition));
    ProjectileVisualDebugger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, 100663691);
    ProjectileVisualDebugger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileVisualDebugger>.NativeClassPtr, 100663692);
  }

  public ProjectileVisualDebugger(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool IsActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_IsActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_IsActive)) = value;
    }
  }

  public unsafe bool _WasActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr__WasActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr__WasActive)) = value;
    }
  }

  public unsafe Transform MoveTransform
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_MoveTransform));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_MoveTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool UseWorldZero
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_UseWorldZero));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_UseWorldZero)) = value;
    }
  }

  public unsafe ProjectileVisualDebugger.MovementType Movement
  {
    get
    {
      return *(ProjectileVisualDebugger.MovementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_Movement));
    }
    [param: In] set
    {
      *(ProjectileVisualDebugger.MovementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_Movement)) = value;
    }
  }

  public unsafe float Distance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_Distance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_Distance)) = value;
    }
  }

  public unsafe float Speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_Speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_Speed)) = value;
    }
  }

  public unsafe Vector3 Direction
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_Direction));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr_Direction)) = value;
    }
  }

  public unsafe Vector3 _OriginalPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr__OriginalPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileVisualDebugger.NativeFieldInfoPtr__OriginalPosition)) = value;
    }
  }

  public enum MovementType
  {
    None,
    OneDirection,
    PingPong,
  }
}
