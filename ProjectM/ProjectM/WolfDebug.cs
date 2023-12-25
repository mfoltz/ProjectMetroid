// Decompiled with JetBrains decompiler
// Type: ProjectM.WolfDebug
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
namespace ProjectM
{
  public class WolfDebug : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SAHandler;
    private static readonly IntPtr NativeFieldInfoPtr_AimTarget;
    private static readonly IntPtr NativeFieldInfoPtr__Animator;
    private static readonly IntPtr NativeFieldInfoPtr__Speed;
    private static readonly IntPtr NativeFieldInfoPtr__FeetLocked;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977009, XrefRangeEnd = 977013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WolfDebug.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977013, XrefRangeEnd = 977036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WolfDebug.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WolfDebug()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WolfDebug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WolfDebug()
    {
      Il2CppClassPointerStore<WolfDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WolfDebug));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr);
      WolfDebug.NativeFieldInfoPtr_SAHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr, nameof (SAHandler));
      WolfDebug.NativeFieldInfoPtr_AimTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr, nameof (AimTarget));
      WolfDebug.NativeFieldInfoPtr__Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr, nameof (_Animator));
      WolfDebug.NativeFieldInfoPtr__Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr, nameof (_Speed));
      WolfDebug.NativeFieldInfoPtr__FeetLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr, nameof (_FeetLocked));
      WolfDebug.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr, 100675500);
      WolfDebug.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr, 100675501);
      WolfDebug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WolfDebug>.NativeClassPtr, 100675502);
    }

    public WolfDebug(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe QuadrupedSecondaryAnimationHandler SAHandler
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr_SAHandler));
        return pointer == IntPtr.Zero ? (QuadrupedSecondaryAnimationHandler) null : new QuadrupedSecondaryAnimationHandler(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr_SAHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform AimTarget
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr_AimTarget));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr_AimTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Animator _Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr__Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr__Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr__Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr__Speed)) = value;
      }
    }

    public unsafe bool _FeetLocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr__FeetLocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WolfDebug.NativeFieldInfoPtr__FeetLocked)) = value;
      }
    }
  }
}
