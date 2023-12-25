// Decompiled with JetBrains decompiler
// Type: FreeFlightCameraComponent
// Assembly: ProjectM.Roofs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D6B6D22B-4E3A-4809-82A6-CC2DECC85297
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Roofs.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class FreeFlightCameraComponent : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_acceleration;
  private static readonly System.IntPtr NativeFieldInfoPtr_accSprintMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookSensitivity;
  private static readonly System.IntPtr NativeFieldInfoPtr_dampingCoefficient;
  private static readonly System.IntPtr NativeFieldInfoPtr_velocity;
  private static readonly System.IntPtr NativeFieldInfoPtr__Focused;
  private static readonly System.IntPtr NativeFieldInfoPtr__FramesFocused;
  private static readonly System.IntPtr NativeFieldInfoPtr__FocusedCenterPos;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPosition_Public_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorPos_Private_Static_Boolean_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Focused_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Focused_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCenterMousePos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAccelerationVector_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_KeyCode_Vector3_byref___c__DisplayClass18_0_PDM_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1636985, XrefRangeEnd = 1636987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetCursorPos(out FreeFlightCameraComponent.POINT lpPoint)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref lpPoint;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1636989, RefRangeEnd = 1636991, XrefRangeStart = 1636987, XrefRangeEnd = 1636989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2 GetCursorPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_GetCursorPosition_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1636991, XrefRangeEnd = 1636993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SetCursorPos(int X, int Y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &X;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &Y;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_SetCursorPos_Private_Static_Boolean_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  public unsafe bool Focused
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_get_Focused_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1636993, XrefRangeEnd = 1636994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_set_Focused_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1636998, RefRangeEnd = 1637000, XrefRangeStart = 1636994, XrefRangeEnd = 1636998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCenterMousePos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_SetCenterMousePos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637000, XrefRangeEnd = 1637015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1637029, RefRangeEnd = 1637030, XrefRangeStart = 1637015, XrefRangeEnd = 1637029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateInput(Vector2 mousePosDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &mousePosDelta;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_UpdateInput_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1637046, RefRangeEnd = 1637047, XrefRangeStart = 1637030, XrefRangeEnd = 1637046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetAccelerationVector()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_GetAccelerationVector_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637047, XrefRangeEnd = 1637048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FreeFlightCameraComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637048, XrefRangeEnd = 1637049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Internal_Static_Void_KeyCode_Vector3_byref___c__DisplayClass18_0_PDM_0(
    KeyCode key,
    Vector3 dir,
    ref FreeFlightCameraComponent.__c__DisplayClass18_0 _param2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref _param2;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FreeFlightCameraComponent.NativeMethodInfoPtr_Method_Internal_Static_Void_KeyCode_Vector3_byref___c__DisplayClass18_0_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FreeFlightCameraComponent()
  {
    Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Roofs.dll", "", nameof (FreeFlightCameraComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr);
    FreeFlightCameraComponent.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (acceleration));
    FreeFlightCameraComponent.NativeFieldInfoPtr_accSprintMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (accSprintMultiplier));
    FreeFlightCameraComponent.NativeFieldInfoPtr_lookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (lookSensitivity));
    FreeFlightCameraComponent.NativeFieldInfoPtr_dampingCoefficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (dampingCoefficient));
    FreeFlightCameraComponent.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (velocity));
    FreeFlightCameraComponent.NativeFieldInfoPtr__Focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (_Focused));
    FreeFlightCameraComponent.NativeFieldInfoPtr__FramesFocused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (_FramesFocused));
    FreeFlightCameraComponent.NativeFieldInfoPtr__FocusedCenterPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (_FocusedCenterPos));
    FreeFlightCameraComponent.NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663297);
    FreeFlightCameraComponent.NativeMethodInfoPtr_GetCursorPosition_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663298);
    FreeFlightCameraComponent.NativeMethodInfoPtr_SetCursorPos_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663299);
    FreeFlightCameraComponent.NativeMethodInfoPtr_get_Focused_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663300);
    FreeFlightCameraComponent.NativeMethodInfoPtr_set_Focused_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663301);
    FreeFlightCameraComponent.NativeMethodInfoPtr_SetCenterMousePos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663302);
    FreeFlightCameraComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663303);
    FreeFlightCameraComponent.NativeMethodInfoPtr_UpdateInput_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663304);
    FreeFlightCameraComponent.NativeMethodInfoPtr_GetAccelerationVector_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663305);
    FreeFlightCameraComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663306);
    FreeFlightCameraComponent.NativeMethodInfoPtr_Method_Internal_Static_Void_KeyCode_Vector3_byref___c__DisplayClass18_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, 100663307);
  }

  public FreeFlightCameraComponent(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float acceleration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_acceleration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_acceleration)) = value;
    }
  }

  public unsafe float accSprintMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_accSprintMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_accSprintMultiplier)) = value;
    }
  }

  public unsafe float lookSensitivity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_lookSensitivity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_lookSensitivity)) = value;
    }
  }

  public unsafe float dampingCoefficient
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_dampingCoefficient));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_dampingCoefficient)) = value;
    }
  }

  public unsafe Vector3 velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr_velocity)) = value;
    }
  }

  public unsafe bool _Focused
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr__Focused));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr__Focused)) = value;
    }
  }

  public unsafe int _FramesFocused
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr__FramesFocused));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr__FramesFocused)) = value;
    }
  }

  public unsafe Vector2 _FocusedCenterPos
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr__FocusedCenterPos));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeFlightCameraComponent.NativeFieldInfoPtr__FocusedCenterPos)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct POINT
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_X;
    private static readonly System.IntPtr NativeFieldInfoPtr_Y;
    [FieldOffset(0)]
    public int X;
    [FieldOffset(4)]
    public int Y;

    static POINT()
    {
      Il2CppClassPointerStore<FreeFlightCameraComponent.POINT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, nameof (POINT));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeFlightCameraComponent.POINT>.NativeClassPtr);
      FreeFlightCameraComponent.POINT.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent.POINT>.NativeClassPtr, nameof (X));
      FreeFlightCameraComponent.POINT.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent.POINT>.NativeClassPtr, nameof (Y));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FreeFlightCameraComponent.POINT>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("FreeFlightCameraComponent/<>c__DisplayClass18_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass18_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_moveInput;
    [FieldOffset(0)]
    public Vector3 moveInput;

    static __c__DisplayClass18_0()
    {
      Il2CppClassPointerStore<FreeFlightCameraComponent.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreeFlightCameraComponent>.NativeClassPtr, "<>c__DisplayClass18_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeFlightCameraComponent.__c__DisplayClass18_0>.NativeClassPtr);
      FreeFlightCameraComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_moveInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeFlightCameraComponent.__c__DisplayClass18_0>.NativeClassPtr, nameof (moveInput));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FreeFlightCameraComponent.__c__DisplayClass18_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
