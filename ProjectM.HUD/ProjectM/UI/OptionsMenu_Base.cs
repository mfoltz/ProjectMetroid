﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OptionsMenu_Base
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class OptionsMenu_Base : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279892, XrefRangeEnd = 1279898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsMenu_Base.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsMenu_Base.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsMenu_Base.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref blockInputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsMenu_Base.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279898, XrefRangeEnd = 1279912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &inputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsMenu_Base.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OptionsMenu_Base()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsMenu_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OptionsMenu_Base()
    {
      Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (OptionsMenu_Base));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr);
      OptionsMenu_Base.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr, nameof (_InputSystem));
      OptionsMenu_Base.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr, 100668986);
      OptionsMenu_Base.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr, 100668987);
      OptionsMenu_Base.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr, 100668988);
      OptionsMenu_Base.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr, 100668989);
      OptionsMenu_Base.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr, 100668990);
      OptionsMenu_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMenu_Base>.NativeClassPtr, 100668991);
    }

    public OptionsMenu_Base(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsMenu_Base.NativeFieldInfoPtr__InputSystem));
        return pointer == IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsMenu_Base.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
