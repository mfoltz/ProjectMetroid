// Decompiled with JetBrains decompiler
// Type: ProjectM.LocomotionLayerBlending
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class LocomotionLayerBlending : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadyBlendDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_StrafeBlendDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_StrafeInputYLowThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_StrafeInputYHighThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_StrafeInputXLowThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_StrafeInputXHighThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr__Animator;
    private static readonly System.IntPtr NativeFieldInfoPtr__StrafeBlend;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReadyBlend;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnabledThisFrame;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976415, XrefRangeEnd = 976422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocomotionLayerBlending.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 149578, RefRangeEnd = 149579, XrefRangeStart = 149578, XrefRangeEnd = 149579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocomotionLayerBlending.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976422, XrefRangeEnd = 976450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocomotionLayerBlending.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976450, XrefRangeEnd = 976451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocomotionLayerBlending()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocomotionLayerBlending.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocomotionLayerBlending()
    {
      Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LocomotionLayerBlending));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr);
      LocomotionLayerBlending.NativeFieldInfoPtr_ReadyBlendDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (ReadyBlendDuration));
      LocomotionLayerBlending.NativeFieldInfoPtr_StrafeBlendDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (StrafeBlendDuration));
      LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputYLowThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (StrafeInputYLowThreshold));
      LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputYHighThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (StrafeInputYHighThreshold));
      LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputXLowThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (StrafeInputXLowThreshold));
      LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputXHighThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (StrafeInputXHighThreshold));
      LocomotionLayerBlending.NativeFieldInfoPtr__Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (_Animator));
      LocomotionLayerBlending.NativeFieldInfoPtr__StrafeBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (_StrafeBlend));
      LocomotionLayerBlending.NativeFieldInfoPtr__ReadyBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (_ReadyBlend));
      LocomotionLayerBlending.NativeFieldInfoPtr__EnabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (_EnabledThisFrame));
      LocomotionLayerBlending.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, 100675460);
      LocomotionLayerBlending.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, 100675461);
      LocomotionLayerBlending.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, 100675462);
      LocomotionLayerBlending.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, 100675463);
    }

    public LocomotionLayerBlending(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float ReadyBlendDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_ReadyBlendDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_ReadyBlendDuration)) = value;
      }
    }

    public unsafe float StrafeBlendDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeBlendDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeBlendDuration)) = value;
      }
    }

    public unsafe float StrafeInputYLowThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputYLowThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputYLowThreshold)) = value;
      }
    }

    public unsafe float StrafeInputYHighThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputYHighThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputYHighThreshold)) = value;
      }
    }

    public unsafe float StrafeInputXLowThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputXLowThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputXLowThreshold)) = value;
      }
    }

    public unsafe float StrafeInputXHighThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputXHighThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr_StrafeInputXHighThreshold)) = value;
      }
    }

    public unsafe Animator _Animator
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr__Animator));
        return pointer == System.IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr__Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _StrafeBlend
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr__StrafeBlend));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr__StrafeBlend)) = value;
      }
    }

    public unsafe float _ReadyBlend
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr__ReadyBlend));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr__ReadyBlend)) = value;
      }
    }

    public unsafe bool _EnabledThisFrame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr__EnabledThisFrame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocomotionLayerBlending.NativeFieldInfoPtr__EnabledThisFrame)) = value;
      }
    }

    public static class Hashes : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_bool_movementKeyPressed;
      private static readonly System.IntPtr NativeFieldInfoPtr_float_baseLayerAnimSpeed;
      private static readonly System.IntPtr NativeFieldInfoPtr_float_instantInputX;
      private static readonly System.IntPtr NativeFieldInfoPtr_float_instantInputY;

      static Hashes()
      {
        Il2CppClassPointerStore<LocomotionLayerBlending.Hashes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocomotionLayerBlending>.NativeClassPtr, nameof (Hashes));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocomotionLayerBlending.Hashes>.NativeClassPtr);
        LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_bool_movementKeyPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending.Hashes>.NativeClassPtr, nameof (bool_movementKeyPressed));
        LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_baseLayerAnimSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending.Hashes>.NativeClassPtr, nameof (float_baseLayerAnimSpeed));
        LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_instantInputX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending.Hashes>.NativeClassPtr, nameof (float_instantInputX));
        LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_instantInputY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocomotionLayerBlending.Hashes>.NativeClassPtr, nameof (float_instantInputY));
      }

      public Hashes(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe int bool_movementKeyPressed
      {
        get
        {
          int movementKeyPressed;
          IL2CPP.il2cpp_field_static_get_value(LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_bool_movementKeyPressed, (void*) &movementKeyPressed);
          return movementKeyPressed;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_bool_movementKeyPressed, (void*) &value);
        }
      }

      public static unsafe int float_baseLayerAnimSpeed
      {
        get
        {
          int baseLayerAnimSpeed;
          IL2CPP.il2cpp_field_static_get_value(LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_baseLayerAnimSpeed, (void*) &baseLayerAnimSpeed);
          return baseLayerAnimSpeed;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_baseLayerAnimSpeed, (void*) &value);
        }
      }

      public static unsafe int float_instantInputX
      {
        get
        {
          int floatInstantInputX;
          IL2CPP.il2cpp_field_static_get_value(LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_instantInputX, (void*) &floatInstantInputX);
          return floatInstantInputX;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_instantInputX, (void*) &value);
        }
      }

      public static unsafe int float_instantInputY
      {
        get
        {
          int floatInstantInputY;
          IL2CPP.il2cpp_field_static_get_value(LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_instantInputY, (void*) &floatInstantInputY);
          return floatInstantInputY;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LocomotionLayerBlending.Hashes.NativeFieldInfoPtr_float_instantInputY, (void*) &value);
        }
      }
    }
  }
}
