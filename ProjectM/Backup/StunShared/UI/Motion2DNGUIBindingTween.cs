// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DNGUIBindingTween
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
namespace StunShared.UI
{
  public class Motion2DNGUIBindingTween : Motion2DNGUIBinding
  {
    private static readonly IntPtr NativeFieldInfoPtr_Duration;
    private static readonly IntPtr NativeFieldInfoPtr_Delay;
    private static readonly IntPtr NativeFieldInfoPtr_LoopTimes;
    private static readonly IntPtr NativeFieldInfoPtr_TweenType;
    private static readonly IntPtr NativeFieldInfoPtr_PlayOnAwake;
    private static readonly IntPtr NativeFieldInfoPtr_ResetOnStop;
    private static readonly IntPtr NativeFieldInfoPtr__CurrentTimeValue;
    private static readonly IntPtr NativeFieldInfoPtr__IsRunning;
    private static readonly IntPtr NativeFieldInfoPtr__LoopCount;
    private static readonly IntPtr NativeFieldInfoPtr__Direction;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTimeValue_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsAtEnd_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ReachedLimit_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetObjectStartValues_Public_Void_GameObject_Motion2DValues_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetObjectEndValues_Public_Void_GameObject_Motion2DValues_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetObjectStartPosition_Public_Void_GameObject_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetObjectStartPosition_Public_Vector2_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetObjectEndPosition_Public_Void_GameObject_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetObjectEndPosition_Public_Vector2_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetStartPosition_Public_Void_GameObject_Int32_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetEndPosition_Public_Void_GameObject_Int32_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetStartColor_Public_Void_GameObject_Int32_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetEndColor_Public_Void_GameObject_Int32_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe float CurrentTimeValue
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 587828, RefRangeEnd = 587829, XrefRangeStart = 587828, XrefRangeEnd = 587829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_get_CurrentTimeValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsAtEnd
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_get_IsAtEnd_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsRunning
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923180, XrefRangeEnd = 923181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Play(bool forward = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &forward;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_Play_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923181, XrefRangeEnd = 923188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923190, RefRangeEnd = 923191, XrefRangeStart = 923188, XrefRangeEnd = 923190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReachedLimit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_ReachedLimit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923191, XrefRangeEnd = 923192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Stop()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923192, XrefRangeEnd = 923194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset(bool start = true, bool evaluate = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &start;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &evaluate;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_Reset_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923194, XrefRangeEnd = 923199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetObjectStartValues(GameObject gameObject, Motion2DValues values)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &values;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetObjectStartValues_Public_Void_GameObject_Motion2DValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923199, XrefRangeEnd = 923204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetObjectEndValues(GameObject gameObject, Motion2DValues values)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &values;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetObjectEndValues_Public_Void_GameObject_Motion2DValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923204, XrefRangeEnd = 923209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetObjectStartPosition(GameObject gameObject, Vector2 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetObjectStartPosition_Public_Void_GameObject_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923209, XrefRangeEnd = 923214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector2 GetObjectStartPosition(GameObject gameObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_GetObjectStartPosition_Public_Vector2_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923214, XrefRangeEnd = 923219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetObjectEndPosition(GameObject gameObject, Vector2 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetObjectEndPosition_Public_Void_GameObject_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923219, XrefRangeEnd = 923224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector2 GetObjectEndPosition(GameObject gameObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_GetObjectEndPosition_Public_Vector2_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923224, XrefRangeEnd = 923229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetStartPosition(GameObject obj, int bindingIndex, Vector2 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &bindingIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetStartPosition_Public_Void_GameObject_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923229, XrefRangeEnd = 923234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetEndPosition(GameObject obj, int bindingIndex, Vector2 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &bindingIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetEndPosition_Public_Void_GameObject_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923234, XrefRangeEnd = 923239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetStartColor(GameObject obj, int bindingIndex, Color color)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &bindingIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &color;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetStartColor_Public_Void_GameObject_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923239, XrefRangeEnd = 923244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetEndColor(GameObject obj, int bindingIndex, Color color)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &bindingIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &color;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetEndColor_Public_Void_GameObject_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923244, XrefRangeEnd = 923245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DNGUIBindingTween()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DNGUIBindingTween.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Motion2DNGUIBindingTween()
    {
      Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DNGUIBindingTween));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr);
      Motion2DNGUIBindingTween.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (Duration));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (Delay));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr_LoopTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (LoopTimes));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr_TweenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (TweenType));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr_PlayOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (PlayOnAwake));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr_ResetOnStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (ResetOnStop));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr__CurrentTimeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (_CurrentTimeValue));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr__IsRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (_IsRunning));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr__LoopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (_LoopCount));
      Motion2DNGUIBindingTween.NativeFieldInfoPtr__Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, nameof (_Direction));
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_get_CurrentTimeValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663837);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_get_IsAtEnd_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663838);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663839);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663840);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_Play_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663841);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663842);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_ReachedLimit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663843);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663844);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_Reset_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663845);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetObjectStartValues_Public_Void_GameObject_Motion2DValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663846);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetObjectEndValues_Public_Void_GameObject_Motion2DValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663847);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetObjectStartPosition_Public_Void_GameObject_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663848);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_GetObjectStartPosition_Public_Vector2_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663849);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetObjectEndPosition_Public_Void_GameObject_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663850);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_GetObjectEndPosition_Public_Vector2_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663851);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetStartPosition_Public_Void_GameObject_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663852);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetEndPosition_Public_Void_GameObject_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663853);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetStartColor_Public_Void_GameObject_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663854);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr_SetEndColor_Public_Void_GameObject_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663855);
      Motion2DNGUIBindingTween.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DNGUIBindingTween>.NativeClassPtr, 100663856);
    }

    public Motion2DNGUIBindingTween(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe float Delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_Delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_Delay)) = value;
      }
    }

    public unsafe int LoopTimes
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_LoopTimes));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_LoopTimes)) = value;
      }
    }

    public unsafe TweenType TweenType
    {
      get
      {
        return *(TweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_TweenType));
      }
      [param: In] set
      {
        *(TweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_TweenType)) = value;
      }
    }

    public unsafe bool PlayOnAwake
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_PlayOnAwake));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_PlayOnAwake)) = value;
      }
    }

    public unsafe bool ResetOnStop
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_ResetOnStop));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr_ResetOnStop)) = value;
      }
    }

    public unsafe float _CurrentTimeValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr__CurrentTimeValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr__CurrentTimeValue)) = value;
      }
    }

    public unsafe bool _IsRunning
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr__IsRunning));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr__IsRunning)) = value;
      }
    }

    public unsafe int _LoopCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr__LoopCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr__LoopCount)) = value;
      }
    }

    public unsafe TweenDirection _Direction
    {
      get
      {
        return *(TweenDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr__Direction));
      }
      [param: In] set
      {
        *(TweenDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DNGUIBindingTween.NativeFieldInfoPtr__Direction)) = value;
      }
    }
  }
}
