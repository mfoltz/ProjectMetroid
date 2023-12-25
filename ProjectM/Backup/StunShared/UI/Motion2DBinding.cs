// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DBinding
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  public class Motion2DBinding : Motion2DNGUIBinding
  {
    private static readonly IntPtr NativeFieldInfoPtr_PlaybackType;
    private static readonly IntPtr NativeFieldInfoPtr_Duration;
    private static readonly IntPtr NativeFieldInfoPtr_PlayOnEnable;
    private static readonly IntPtr NativeFieldInfoPtr__EnableTime;
    private static readonly IntPtr NativeFieldInfoPtr__PreviousT;
    private static readonly IntPtr NativeMethodInfoPtr_get_EvaluateDuration_Public_Virtual_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_EvaluateDuration_Public_Virtual_set_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_EnableTime_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_EvaluateTime_Public_Virtual_State_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float EvaluateDuration
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Motion2DBinding.NativeMethodInfoPtr_get_EvaluateDuration_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 308450, RefRangeEnd = 308451, XrefRangeStart = 308450, XrefRangeEnd = 308451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Motion2DBinding.NativeMethodInfoPtr_set_EvaluateDuration_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float EnableTime
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DBinding.NativeMethodInfoPtr_get_EnableTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922346, XrefRangeEnd = 922348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DBinding.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922348, XrefRangeEnd = 922351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DBinding.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922351, XrefRangeEnd = 922354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Evaluateable.State EvaluateTime(float elapsed, bool invokeEventCallbacks = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &elapsed;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &invokeEventCallbacks;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Motion2DBinding.NativeMethodInfoPtr_EvaluateTime_Public_Virtual_State_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Evaluateable.State*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922354, XrefRangeEnd = 922355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DBinding()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DBinding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Motion2DBinding()
    {
      Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DBinding));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr);
      Motion2DBinding.NativeFieldInfoPtr_PlaybackType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, nameof (PlaybackType));
      Motion2DBinding.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, nameof (Duration));
      Motion2DBinding.NativeFieldInfoPtr_PlayOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, nameof (PlayOnEnable));
      Motion2DBinding.NativeFieldInfoPtr__EnableTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, nameof (_EnableTime));
      Motion2DBinding.NativeFieldInfoPtr__PreviousT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, nameof (_PreviousT));
      Motion2DBinding.NativeMethodInfoPtr_get_EvaluateDuration_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, 100663761);
      Motion2DBinding.NativeMethodInfoPtr_set_EvaluateDuration_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, 100663762);
      Motion2DBinding.NativeMethodInfoPtr_get_EnableTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, 100663763);
      Motion2DBinding.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, 100663764);
      Motion2DBinding.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, 100663765);
      Motion2DBinding.NativeMethodInfoPtr_EvaluateTime_Public_Virtual_State_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, 100663766);
      Motion2DBinding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DBinding>.NativeClassPtr, 100663767);
    }

    public Motion2DBinding(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PlaybackType PlaybackType
    {
      get
      {
        return *(PlaybackType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr_PlaybackType));
      }
      [param: In] set
      {
        *(PlaybackType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr_PlaybackType)) = value;
      }
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe bool PlayOnEnable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr_PlayOnEnable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr_PlayOnEnable)) = value;
      }
    }

    public unsafe float _EnableTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr__EnableTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr__EnableTime)) = value;
      }
    }

    public unsafe float _PreviousT
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr__PreviousT));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DBinding.NativeFieldInfoPtr__PreviousT)) = value;
      }
    }
  }
}
