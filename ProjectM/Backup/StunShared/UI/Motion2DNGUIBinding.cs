// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DNGUIBinding
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace StunShared.UI
{
  public class Motion2DNGUIBinding : Evaluateable
  {
    private static readonly IntPtr NativeFieldInfoPtr_Data;
    private static readonly IntPtr NativeFieldInfoPtr__OriginalBindings_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr_Events;
    private static readonly IntPtr NativeFieldInfoPtr__Graphics;
    private static readonly IntPtr NativeFieldInfoPtr__PrevTime;
    private static readonly IntPtr NativeMethodInfoPtr_get_OriginalBindings_Public_get_Il2CppReferenceArray_1_Motion2DTimelineBinding_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_OriginalBindings_Private_set_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_0;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetMotion2DValues_Public_Static_Motion2DValues_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDifference_Public_Static_Motion2DMask_Motion2DValues_Motion2DValues_Motion2DMask_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_Color_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetGraphicComponents_Public_Static_Void_GameObject_byref_CanvasGroup_byref_TextMeshProUGUI_byref_Text_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetMotion2DValues_Public_Static_Void_byref_Motion2DValues_GameObject_Motion2DMask_Motion2DComponentData_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetMotion2DValues_Public_Static_Void_byref_Motion2DValues_GameObject_Motion2DMask_0;
    private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetComponentData_Public_Static_Motion2DComponentData_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_EvaluateTime_Public_Virtual_State_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Void_Single_Motion2DBindingData_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe Il2CppReferenceArray<Motion2DTimelineBinding> OriginalBindings
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 22398, RefRangeEnd = 22405, XrefRangeStart = 22398, XrefRangeEnd = 22405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_get_OriginalBindings_Public_get_Il2CppReferenceArray_1_Motion2DTimelineBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Motion2DTimelineBinding>) null : new Il2CppReferenceArray<Motion2DTimelineBinding>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23675, RefRangeEnd = 23677, XrefRangeStart = 23675, XrefRangeEnd = 23677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_set_OriginalBindings_Private_set_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922771, XrefRangeEnd = 922777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922777, XrefRangeEnd = 922815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Motion2DValues GetMotion2DValues(GameObject go)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_GetMotion2DValues_Public_Static_Motion2DValues_GameObject_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Motion2DValues*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922815, XrefRangeEnd = 922826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Motion2DMask GetDifference(
      Motion2DValues values1,
      Motion2DValues values2,
      Motion2DMask mask)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &values1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &values2;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &mask;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_GetDifference_Public_Static_Motion2DMask_Motion2DValues_Motion2DValues_Motion2DMask_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Motion2DMask*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe Color GetColor(Color color, float alpha)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &color;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &alpha;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_GetColor_Public_Static_Color_Color_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922826, XrefRangeEnd = 922856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetGraphicComponents(
      GameObject go,
      out CanvasGroup canvasGroup,
      out TextMeshProUGUI textMeshPro,
      out Text text)
    {
      IntPtr* numPtr1 = stackalloc IntPtr[4];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero1 = IntPtr.Zero;
      IntPtr* numPtr2 = &zero1;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr num2 = (IntPtr) numPtr1 + checked (new IntPtr(2) * sizeof (IntPtr));
      IntPtr zero2 = IntPtr.Zero;
      IntPtr* numPtr3 = &zero2;
      *(IntPtr*) num2 = (IntPtr) numPtr3;
      IntPtr num3 = (IntPtr) numPtr1 + checked (new IntPtr(3) * sizeof (IntPtr));
      IntPtr zero3 = IntPtr.Zero;
      IntPtr* numPtr4 = &zero3;
      *(IntPtr*) num3 = (IntPtr) numPtr4;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_GetGraphicComponents_Public_Static_Void_GameObject_byref_CanvasGroup_byref_TextMeshProUGUI_byref_Text_0, IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref CanvasGroup local1 = ref canvasGroup;
      IntPtr pointer1 = zero1;
      CanvasGroup canvasGroup1 = pointer1 == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer1);
      local1 = canvasGroup1;
      ref TextMeshProUGUI local2 = ref textMeshPro;
      IntPtr pointer2 = zero2;
      TextMeshProUGUI textMeshProUgui = pointer2 == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer2);
      local2 = textMeshProUgui;
      ref Text local3 = ref text;
      IntPtr pointer3 = zero3;
      Text text1 = pointer3 == IntPtr.Zero ? (Text) null : new Text(pointer3);
      local3 = text1;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 922919, RefRangeEnd = 922921, XrefRangeStart = 922856, XrefRangeEnd = 922919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetMotion2DValues(
      ref Motion2DValues values,
      GameObject go,
      Motion2DMask mask,
      Motion2DComponentData componentData)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) ref values;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &mask;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) componentData));
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_SetMotion2DValues_Public_Static_Void_byref_Motion2DValues_GameObject_Motion2DMask_Motion2DComponentData_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 923065, RefRangeEnd = 923067, XrefRangeStart = 922921, XrefRangeEnd = 923065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetMotion2DValues(
      ref Motion2DValues values,
      GameObject go,
      Motion2DMask mask)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) ref values;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &mask;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_SetMotion2DValues_Public_Static_Void_byref_Motion2DValues_GameObject_Motion2DMask_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 923091, RefRangeEnd = 923109, XrefRangeStart = 923067, XrefRangeEnd = 923091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Evaluate(float t, bool invokeEventCallbacks = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &t;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &invokeEventCallbacks;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_Evaluate_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923145, RefRangeEnd = 923146, XrefRangeStart = 923109, XrefRangeEnd = 923145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Motion2DComponentData GetComponentData(GameObject go)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
      IntPtr exc;
      IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_GetComponentData_Public_Static_Motion2DComponentData_GameObject_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Motion2DComponentData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923146, XrefRangeEnd = 923152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Evaluateable.State EvaluateTime(float elapsed, bool invokeEventCallbacks = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &elapsed;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &invokeEventCallbacks;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Motion2DNGUIBinding.NativeMethodInfoPtr_EvaluateTime_Public_Virtual_State_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Evaluateable.State*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923169, RefRangeEnd = 923170, XrefRangeStart = 923152, XrefRangeEnd = 923169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Evaluate(float t, Motion2DBindingData data)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &t;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr_Evaluate_Public_Static_Void_Single_Motion2DBindingData_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 923178, RefRangeEnd = 923180, XrefRangeStart = 923170, XrefRangeEnd = 923178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DNGUIBinding()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBinding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Motion2DNGUIBinding()
    {
      Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DNGUIBinding));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr);
      Motion2DNGUIBinding.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, nameof (Data));
      Motion2DNGUIBinding.NativeFieldInfoPtr__OriginalBindings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, "<OriginalBindings>k__BackingField");
      Motion2DNGUIBinding.NativeFieldInfoPtr_Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, nameof (Events));
      Motion2DNGUIBinding.NativeFieldInfoPtr__Graphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, nameof (_Graphics));
      Motion2DNGUIBinding.NativeFieldInfoPtr__PrevTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, nameof (_PrevTime));
      Motion2DNGUIBinding.NativeMethodInfoPtr_get_OriginalBindings_Public_get_Il2CppReferenceArray_1_Motion2DTimelineBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663823);
      Motion2DNGUIBinding.NativeMethodInfoPtr_set_OriginalBindings_Private_set_Void_Il2CppReferenceArray_1_Motion2DTimelineBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663824);
      Motion2DNGUIBinding.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663825);
      Motion2DNGUIBinding.NativeMethodInfoPtr_GetMotion2DValues_Public_Static_Motion2DValues_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663826);
      Motion2DNGUIBinding.NativeMethodInfoPtr_GetDifference_Public_Static_Motion2DMask_Motion2DValues_Motion2DValues_Motion2DMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663827);
      Motion2DNGUIBinding.NativeMethodInfoPtr_GetColor_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663828);
      Motion2DNGUIBinding.NativeMethodInfoPtr_GetGraphicComponents_Public_Static_Void_GameObject_byref_CanvasGroup_byref_TextMeshProUGUI_byref_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663829);
      Motion2DNGUIBinding.NativeMethodInfoPtr_SetMotion2DValues_Public_Static_Void_byref_Motion2DValues_GameObject_Motion2DMask_Motion2DComponentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663830);
      Motion2DNGUIBinding.NativeMethodInfoPtr_SetMotion2DValues_Public_Static_Void_byref_Motion2DValues_GameObject_Motion2DMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663831);
      Motion2DNGUIBinding.NativeMethodInfoPtr_Evaluate_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663832);
      Motion2DNGUIBinding.NativeMethodInfoPtr_GetComponentData_Public_Static_Motion2DComponentData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663833);
      Motion2DNGUIBinding.NativeMethodInfoPtr_EvaluateTime_Public_Virtual_State_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663834);
      Motion2DNGUIBinding.NativeMethodInfoPtr_Evaluate_Public_Static_Void_Single_Motion2DBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663835);
      Motion2DNGUIBinding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBinding>.NativeClassPtr, 100663836);
    }

    public Motion2DNGUIBinding(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Motion2DBindingData Data
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBinding.NativeFieldInfoPtr_Data));
        return pointer == IntPtr.Zero ? (Motion2DBindingData) null : new Motion2DBindingData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBinding.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Motion2DTimelineBinding> _OriginalBindings_k__BackingField
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBinding.NativeFieldInfoPtr__OriginalBindings_k__BackingField));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Motion2DTimelineBinding>) null : new Il2CppReferenceArray<Motion2DTimelineBinding>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBinding.NativeFieldInfoPtr__OriginalBindings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Motion2DEvent> Events
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBinding.NativeFieldInfoPtr_Events));
        return pointer == IntPtr.Zero ? (List<Motion2DEvent>) null : new List<Motion2DEvent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBinding.NativeFieldInfoPtr_Events), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<Graphic> _Graphics
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Motion2DNGUIBinding.NativeFieldInfoPtr__Graphics, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<Graphic>) null : new List<Graphic>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Motion2DNGUIBinding.NativeFieldInfoPtr__Graphics, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _PrevTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBinding.NativeFieldInfoPtr__PrevTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBinding.NativeFieldInfoPtr__PrevTime)) = value;
      }
    }
  }
}
