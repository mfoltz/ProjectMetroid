// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SimplePopupBase
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class SimplePopupBase : MonoBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Show_Public_SimplePopupBase_0;
    private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_New_Void_InputState_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Abstract_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public unsafe bool IsOpen
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1164685, RefRangeEnd = 1164687, XrefRangeStart = 1164682, XrefRangeEnd = 1164685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimplePopupBase.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1164689, RefRangeEnd = 1164695, XrefRangeStart = 1164687, XrefRangeEnd = 1164689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SimplePopupBase Show()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimplePopupBase.NativeMethodInfoPtr_Show_Public_SimplePopupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SimplePopupBase) null : new SimplePopupBase(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164695, XrefRangeEnd = 1164697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Close()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimplePopupBase.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &inputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimplePopupBase.NativeMethodInfoPtr_HandleInput_Public_Virtual_New_Void_InputState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnShow()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimplePopupBase.NativeMethodInfoPtr_OnShow_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnClose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimplePopupBase.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SimplePopupBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimplePopupBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SimplePopupBase()
    {
      Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (SimplePopupBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr);
      SimplePopupBase.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr, 100692616);
      SimplePopupBase.NativeMethodInfoPtr_Show_Public_SimplePopupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr, 100692617);
      SimplePopupBase.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr, 100692618);
      SimplePopupBase.NativeMethodInfoPtr_HandleInput_Public_Virtual_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr, 100692619);
      SimplePopupBase.NativeMethodInfoPtr_OnShow_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr, 100692620);
      SimplePopupBase.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr, 100692621);
      SimplePopupBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimplePopupBase>.NativeClassPtr, 100692622);
    }

    public SimplePopupBase(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
