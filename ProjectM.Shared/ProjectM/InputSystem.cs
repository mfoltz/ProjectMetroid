// Decompiled with JetBrains decompiler
// Type: ProjectM.InputSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class InputSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GetInputMapProfilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__GetInputFlagFromAnalogInputMapMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultInputSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_MergedInputSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr__TopMostInputState_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DenyModificationsOfInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr__ControllerType_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AnalogValues;
    private static readonly System.IntPtr NativeFieldInfoPtr__ControlsVisualMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionPerspectivePlane;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionPlayerPlane;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionPlayerPlaneTerrainProjection;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseWorldPositionFilterByHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputChangeVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedKeycodeToString;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputsUp;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputsDown;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputsPressed;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TopMostInputState_Public_get_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TopMostInputState_Private_set_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ControllerType_Public_get_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ControllerType_Private_set_Void_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BumpVersion_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInputFlagFromAnalogInputMap_Public_Void_AnalogInput_Boolean_byref_String_byref_Sprite_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyCodeString_Private_String_KeyCode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyInputMap_Public_Void_InputFlag_byref_String_byref_Sprite_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputContext_Public_Void_TContext_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputContext_Public_Void_IInputContext_World_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputContext_Private_Void_IInputContext_Object_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInputContext_Public_Void_IInputContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreToDefault_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveSettings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyKeyInputSetting_Public_Void_InputFlag_KeyCode_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyAnalogSetting_Public_Void_AnalogInput_KeyCode_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupMergedSettings_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupController_Private_Void_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsContextRegistered_Public_Boolean_IInputContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAnalogInputLocalization_Public_Boolean_AnalogInput_Boolean_byref_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInputFlagLocalization_Public_Boolean_InputFlag_byref_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe InputState TopMostInputState
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_get_TopMostInputState_Public_get_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(InputState*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_set_TopMostInputState_Private_set_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ControllerType ControllerType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_get_ControllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ControllerType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_set_ControllerType_Private_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public unsafe void BumpVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_BumpVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 741774, RefRangeEnd = 741780, XrefRangeStart = 741703, XrefRangeEnd = 741774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetInputFlagFromAnalogInputMap(
      AnalogInput analogInputType,
      bool positive,
      out string inputText,
      out Sprite inputIcon,
      bool primary = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = (System.IntPtr) &analogInputType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positive;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &primary;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_GetInputFlagFromAnalogInputMap_Public_Void_AnalogInput_Boolean_byref_String_byref_Sprite_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      inputText = IL2CPP.Il2CppStringToManaged(zero1);
      ref Sprite local = ref inputIcon;
      System.IntPtr pointer = zero2;
      Sprite sprite = pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      local = sprite;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 741790, RefRangeEnd = 741792, XrefRangeStart = 741780, XrefRangeEnd = 741790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetKeyCodeString(KeyCode keyCode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &keyCode;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_GetKeyCodeString_Private_String_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 741859, RefRangeEnd = 741878, XrefRangeStart = 741792, XrefRangeEnd = 741859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetKeyInputMap(
      InputFlag input,
      out string inputText,
      out Sprite inputIcon,
      bool primary = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &input;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &primary;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_GetKeyInputMap_Public_Void_InputFlag_byref_String_byref_Sprite_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      inputText = IL2CPP.Il2CppStringToManaged(zero1);
      ref Sprite local = ref inputIcon;
      System.IntPtr pointer = zero2;
      Sprite sprite = pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      local = sprite;
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 741879, RefRangeEnd = 741894, XrefRangeStart = 741878, XrefRangeEnd = 741879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddInputContext<TContext>(TContext inputContext, int order = 0) where TContext : UnityEngine.Object
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TContext& local1;
      if (!typeof (TContext).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TContext> local2 = (object) inputContext;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TContext&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TContext&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref inputContext;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &order;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.MethodInfoStoreGeneric_AddInputContext_Public_Void_TContext_Int32_0<TContext>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(56)]
    [CachedScanResults(RefRangeStart = 741895, RefRangeEnd = 741951, XrefRangeStart = 741894, XrefRangeEnd = 741895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddInputContext(IInputContext inputContext, World contextOwner, int order = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputContext);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) contextOwner);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &order;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_AddInputContext_Public_Void_IInputContext_World_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 741971, RefRangeEnd = 741973, XrefRangeStart = 741951, XrefRangeEnd = 741971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddInputContext(IInputContext inputContext, Il2CppSystem.Object contextOwner, int order)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputContext);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) contextOwner);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &order;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_AddInputContext_Private_Void_IInputContext_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(73)]
    [CachedScanResults(RefRangeStart = 741991, RefRangeEnd = 742064, XrefRangeStart = 741973, XrefRangeEnd = 741991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveInputContext(IInputContext inputContext)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputContext);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_RemoveInputContext_Public_Void_IInputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742064, XrefRangeEnd = 742072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742072, XrefRangeEnd = 742079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742086, RefRangeEnd = 742087, XrefRangeStart = 742079, XrefRangeEnd = 742086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreToDefault()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_RestoreToDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 742092, RefRangeEnd = 742095, XrefRangeStart = 742087, XrefRangeEnd = 742092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_SaveSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 742113, RefRangeEnd = 742115, XrefRangeStart = 742095, XrefRangeEnd = 742113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ModifyKeyInputSetting(InputFlag inputFlag, KeyCode newKey, bool primary)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inputFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &primary;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_ModifyKeyInputSetting_Public_Void_InputFlag_KeyCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 742137, RefRangeEnd = 742139, XrefRangeStart = 742115, XrefRangeEnd = 742137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ModifyAnalogSetting(
      AnalogInput analogInput,
      KeyCode newKey,
      bool positive,
      bool primary)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &analogInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &positive;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &primary;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_ModifyAnalogSetting_Public_Void_AnalogInput_KeyCode_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 742170, RefRangeEnd = 742174, XrefRangeStart = 742139, XrefRangeEnd = 742170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupMergedSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_SetupMergedSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 742234, RefRangeEnd = 742237, XrefRangeStart = 742174, XrefRangeEnd = 742234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupController(ControllerType controller)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &controller;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_SetupController_Private_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742237, XrefRangeEnd = 742443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742448, RefRangeEnd = 742449, XrefRangeStart = 742443, XrefRangeEnd = 742448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsContextRegistered(IInputContext inputContext)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputContext);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsContextRegistered_Public_Boolean_IInputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 742464, RefRangeEnd = 742466, XrefRangeStart = 742449, XrefRangeEnd = 742464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAnalogInputLocalization(
      AnalogInput analogInput,
      bool positive,
      out LocalizationKey loc)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &analogInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positive;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref loc;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_TryGetAnalogInputLocalization_Public_Boolean_AnalogInput_Boolean_byref_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 742481, RefRangeEnd = 742483, XrefRangeStart = 742466, XrefRangeEnd = 742481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetInputFlagLocalization(InputFlag inputFlag, out LocalizationKey loc)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inputFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loc;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_TryGetInputFlagLocalization_Public_Boolean_InputFlag_byref_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742483, XrefRangeEnd = 742502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InputSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InputSystem()
    {
      Il2CppClassPointerStore<InputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InputSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSystem>.NativeClassPtr);
      InputSystem.NativeFieldInfoPtr__GetInputMapProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_GetInputMapProfilerMarker));
      InputSystem.NativeFieldInfoPtr__GetInputFlagFromAnalogInputMapMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_GetInputFlagFromAnalogInputMapMarker));
      InputSystem.NativeFieldInfoPtr_AnalogCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (AnalogCount));
      InputSystem.NativeFieldInfoPtr_DefaultInputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (DefaultInputSettings));
      InputSystem.NativeFieldInfoPtr_InputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (InputSettings));
      InputSystem.NativeFieldInfoPtr_MergedInputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (MergedInputSettings));
      InputSystem.NativeFieldInfoPtr__InputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_InputContexts));
      InputSystem.NativeFieldInfoPtr__TopMostInputState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "<TopMostInputState>k__BackingField");
      InputSystem.NativeFieldInfoPtr__DenyModificationsOfInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_DenyModificationsOfInputContexts));
      InputSystem.NativeFieldInfoPtr__ControllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "<ControllerType>k__BackingField");
      InputSystem.NativeFieldInfoPtr__AnalogValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_AnalogValues));
      InputSystem.NativeFieldInfoPtr__ControlsVisualMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_ControlsVisualMapping));
      InputSystem.NativeFieldInfoPtr_MouseWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (MouseWorldPosition));
      InputSystem.NativeFieldInfoPtr_MouseWorldPositionPerspectivePlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (MouseWorldPositionPerspectivePlane));
      InputSystem.NativeFieldInfoPtr_MouseWorldPositionPlayerPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (MouseWorldPositionPlayerPlane));
      InputSystem.NativeFieldInfoPtr_MouseWorldPositionPlayerPlaneTerrainProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (MouseWorldPositionPlayerPlaneTerrainProjection));
      InputSystem.NativeFieldInfoPtr_MouseWorldPositionFilterByHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (MouseWorldPositionFilterByHeightLevel));
      InputSystem.NativeFieldInfoPtr_InputChangeVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (InputChangeVersion));
      InputSystem.NativeFieldInfoPtr__CachedKeycodeToString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_CachedKeycodeToString));
      InputSystem.NativeFieldInfoPtr__InputsUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_InputsUp));
      InputSystem.NativeFieldInfoPtr__InputsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_InputsDown));
      InputSystem.NativeFieldInfoPtr__InputsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_InputsPressed));
      InputSystem.NativeMethodInfoPtr_get_TopMostInputState_Public_get_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665438);
      InputSystem.NativeMethodInfoPtr_set_TopMostInputState_Private_set_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665439);
      InputSystem.NativeMethodInfoPtr_get_ControllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665440);
      InputSystem.NativeMethodInfoPtr_set_ControllerType_Private_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665441);
      InputSystem.NativeMethodInfoPtr_BumpVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665442);
      InputSystem.NativeMethodInfoPtr_GetInputFlagFromAnalogInputMap_Public_Void_AnalogInput_Boolean_byref_String_byref_Sprite_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665443);
      InputSystem.NativeMethodInfoPtr_GetKeyCodeString_Private_String_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665444);
      InputSystem.NativeMethodInfoPtr_GetKeyInputMap_Public_Void_InputFlag_byref_String_byref_Sprite_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665445);
      InputSystem.NativeMethodInfoPtr_AddInputContext_Public_Void_TContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665446);
      InputSystem.NativeMethodInfoPtr_AddInputContext_Public_Void_IInputContext_World_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665447);
      InputSystem.NativeMethodInfoPtr_AddInputContext_Private_Void_IInputContext_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665448);
      InputSystem.NativeMethodInfoPtr_RemoveInputContext_Public_Void_IInputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665449);
      InputSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665450);
      InputSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665451);
      InputSystem.NativeMethodInfoPtr_RestoreToDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665452);
      InputSystem.NativeMethodInfoPtr_SaveSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665453);
      InputSystem.NativeMethodInfoPtr_ModifyKeyInputSetting_Public_Void_InputFlag_KeyCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665454);
      InputSystem.NativeMethodInfoPtr_ModifyAnalogSetting_Public_Void_AnalogInput_KeyCode_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665455);
      InputSystem.NativeMethodInfoPtr_SetupMergedSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665456);
      InputSystem.NativeMethodInfoPtr_SetupController_Private_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665457);
      InputSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665458);
      InputSystem.NativeMethodInfoPtr_IsContextRegistered_Public_Boolean_IInputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665459);
      InputSystem.NativeMethodInfoPtr_TryGetAnalogInputLocalization_Public_Boolean_AnalogInput_Boolean_byref_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665460);
      InputSystem.NativeMethodInfoPtr_TryGetInputFlagLocalization_Public_Boolean_InputFlag_byref_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665461);
      InputSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665462);
      InputSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100665464);
    }

    public InputSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ProfilerMarker _GetInputMapProfilerMarker
    {
      get
      {
        ProfilerMarker mapProfilerMarker;
        IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr__GetInputMapProfilerMarker, (void*) &mapProfilerMarker);
        return mapProfilerMarker;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr__GetInputMapProfilerMarker, (void*) &value);
      }
    }

    public static unsafe ProfilerMarker _GetInputFlagFromAnalogInputMapMarker
    {
      get
      {
        ProfilerMarker analogInputMapMarker;
        IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr__GetInputFlagFromAnalogInputMapMarker, (void*) &analogInputMapMarker);
        return analogInputMapMarker;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr__GetInputFlagFromAnalogInputMapMarker, (void*) &value);
      }
    }

    public static unsafe int AnalogCount
    {
      get
      {
        int analogCount;
        IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_AnalogCount, (void*) &analogCount);
        return analogCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_AnalogCount, (void*) &value);
      }
    }

    public unsafe InputSettings DefaultInputSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_DefaultInputSettings));
        return pointer == System.IntPtr.Zero ? (InputSettings) null : new InputSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_DefaultInputSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSettings InputSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_InputSettings));
        return pointer == System.IntPtr.Zero ? (InputSettings) null : new InputSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_InputSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSettings MergedInputSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MergedInputSettings));
        return pointer == System.IntPtr.Zero ? (InputSettings) null : new InputSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MergedInputSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InputSystem.InputContextState> _InputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__InputContexts));
        return pointer == System.IntPtr.Zero ? (List<InputSystem.InputContextState>) null : new List<InputSystem.InputContextState>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__InputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputState _TopMostInputState_k__BackingField
    {
      get
      {
        return *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__TopMostInputState_k__BackingField));
      }
      [param: In] set
      {
        *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__TopMostInputState_k__BackingField)) = value;
      }
    }

    public unsafe bool _DenyModificationsOfInputContexts
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__DenyModificationsOfInputContexts));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__DenyModificationsOfInputContexts)) = value;
      }
    }

    public unsafe ControllerType _ControllerType_k__BackingField
    {
      get
      {
        return *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__ControllerType_k__BackingField));
      }
      [param: In] set
      {
        *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__ControllerType_k__BackingField)) = value;
      }
    }

    public unsafe Il2CppStructArray<float> _AnalogValues
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__AnalogValues));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__AnalogValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ControlsVisualMapping _ControlsVisualMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__ControlsVisualMapping));
        return pointer == System.IntPtr.Zero ? (ControlsVisualMapping) null : new ControlsVisualMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__ControlsVisualMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float3 MouseWorldPosition
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPosition));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPosition)) = value;
      }
    }

    public unsafe float3 MouseWorldPositionPerspectivePlane
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPositionPerspectivePlane));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPositionPerspectivePlane)) = value;
      }
    }

    public unsafe float3 MouseWorldPositionPlayerPlane
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPositionPlayerPlane));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPositionPlayerPlane)) = value;
      }
    }

    public unsafe float3 MouseWorldPositionPlayerPlaneTerrainProjection
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPositionPlayerPlaneTerrainProjection));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPositionPlayerPlaneTerrainProjection)) = value;
      }
    }

    public unsafe float3 MouseWorldPositionFilterByHeightLevel
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPositionFilterByHeightLevel));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_MouseWorldPositionFilterByHeightLevel)) = value;
      }
    }

    public unsafe int InputChangeVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_InputChangeVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_InputChangeVersion)) = value;
      }
    }

    public unsafe Dictionary<KeyCode, string> _CachedKeycodeToString
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__CachedKeycodeToString));
        return pointer == System.IntPtr.Zero ? (Dictionary<KeyCode, string>) null : new Dictionary<KeyCode, string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__CachedKeycodeToString), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<InputFlag> _InputsUp
    {
      get
      {
        return *(NativeList<InputFlag>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__InputsUp));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__InputsUp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InputFlag>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<InputFlag> _InputsDown
    {
      get
      {
        return *(NativeList<InputFlag>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__InputsDown));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__InputsDown), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InputFlag>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<InputFlag> _InputsPressed
    {
      get
      {
        return *(NativeList<InputFlag>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__InputsPressed));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr__InputsPressed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InputFlag>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public sealed class InputContextState : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Order;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputContext;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputsDown;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputsUp;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputsPressed;
      private static readonly System.IntPtr NativeFieldInfoPtr_ContextOwner;

      static InputContextState()
      {
        Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (InputContextState));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr);
        InputSystem.InputContextState.NativeFieldInfoPtr_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr, nameof (Order));
        InputSystem.InputContextState.NativeFieldInfoPtr_InputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr, nameof (InputContext));
        InputSystem.InputContextState.NativeFieldInfoPtr_InputsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr, nameof (InputsDown));
        InputSystem.InputContextState.NativeFieldInfoPtr_InputsUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr, nameof (InputsUp));
        InputSystem.InputContextState.NativeFieldInfoPtr_InputsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr, nameof (InputsPressed));
        InputSystem.InputContextState.NativeFieldInfoPtr_ContextOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr, nameof (ContextOwner));
      }

      public InputContextState(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public InputContextState()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputSystem.InputContextState>.NativeClassPtr, data));
      }

      public unsafe int Order
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_Order));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_Order)) = value;
        }
      }

      public unsafe IInputContext InputContext
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_InputContext));
          return pointer == System.IntPtr.Zero ? (IInputContext) null : new IInputContext(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_InputContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeList<InputFlag> InputsDown
      {
        get
        {
          return *(NativeList<InputFlag>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_InputsDown));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_InputsDown), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InputFlag>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<InputFlag> InputsUp
      {
        get
        {
          return *(NativeList<InputFlag>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_InputsUp));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_InputsUp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InputFlag>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<InputFlag> InputsPressed
      {
        get
        {
          return *(NativeList<InputFlag>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_InputsPressed));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_InputsPressed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InputFlag>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Il2CppSystem.Object ContextOwner
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_ContextOwner));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.InputContextState.NativeFieldInfoPtr_ContextOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_AddInputContext_Public_Void_TContext_Int32_0<TContext>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(InputSystem.NativeMethodInfoPtr_AddInputContext_Public_Void_TContext_Int32_0, Il2CppClassPointerStore<InputSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContext>.NativeClassPtr))
      }))));
    }
  }
}
