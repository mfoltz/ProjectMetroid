// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowTextureStreamingSummary
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
  public class ShowTextureStreamingSummary : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_X;
    private static readonly IntPtr NativeFieldInfoPtr_Y;
    private static readonly IntPtr NativeFieldInfoPtr_MemoryBudgetPercentThreshold;
    private static readonly IntPtr NativeFieldInfoPtr_TextureStreamingPercentThreshold;
    private static readonly IntPtr NativeFieldInfoPtr_HighestDesiredTextureMemory;
    private static readonly IntPtr NativeFieldInfoPtr_TextRect;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HumanReadableSize_Public_String_UInt64_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShowText_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTextureStreamingSummary.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1051384, RefRangeEnd = 1051390, XrefRangeStart = 1051377, XrefRangeEnd = 1051384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string HumanReadableSize(ulong size)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &size;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShowTextureStreamingSummary.NativeMethodInfoPtr_HumanReadableSize_Public_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1051400, RefRangeEnd = 1051407, XrefRangeStart = 1051390, XrefRangeEnd = 1051400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowText(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTextureStreamingSummary.NativeMethodInfoPtr_ShowText_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051407, XrefRangeEnd = 1051506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnGUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTextureStreamingSummary.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051506, XrefRangeEnd = 1051507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowTextureStreamingSummary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTextureStreamingSummary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowTextureStreamingSummary()
    {
      Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShowTextureStreamingSummary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr);
      ShowTextureStreamingSummary.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, nameof (X));
      ShowTextureStreamingSummary.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, nameof (Y));
      ShowTextureStreamingSummary.NativeFieldInfoPtr_MemoryBudgetPercentThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, nameof (MemoryBudgetPercentThreshold));
      ShowTextureStreamingSummary.NativeFieldInfoPtr_TextureStreamingPercentThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, nameof (TextureStreamingPercentThreshold));
      ShowTextureStreamingSummary.NativeFieldInfoPtr_HighestDesiredTextureMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, nameof (HighestDesiredTextureMemory));
      ShowTextureStreamingSummary.NativeFieldInfoPtr_TextRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, nameof (TextRect));
      ShowTextureStreamingSummary.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, 100682602);
      ShowTextureStreamingSummary.NativeMethodInfoPtr_HumanReadableSize_Public_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, 100682603);
      ShowTextureStreamingSummary.NativeMethodInfoPtr_ShowText_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, 100682604);
      ShowTextureStreamingSummary.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, 100682605);
      ShowTextureStreamingSummary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextureStreamingSummary>.NativeClassPtr, 100682606);
    }

    public ShowTextureStreamingSummary(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float X
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_X));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_X)) = value;
      }
    }

    public unsafe float Y
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_Y));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_Y)) = value;
      }
    }

    public unsafe int MemoryBudgetPercentThreshold
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_MemoryBudgetPercentThreshold));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_MemoryBudgetPercentThreshold)) = value;
      }
    }

    public unsafe int TextureStreamingPercentThreshold
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_TextureStreamingPercentThreshold));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_TextureStreamingPercentThreshold)) = value;
      }
    }

    public unsafe ulong HighestDesiredTextureMemory
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_HighestDesiredTextureMemory));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_HighestDesiredTextureMemory)) = value;
      }
    }

    public unsafe Rect TextRect
    {
      get
      {
        return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_TextRect));
      }
      [param: In] set
      {
        *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTextureStreamingSummary.NativeFieldInfoPtr_TextRect)) = value;
      }
    }
  }
}
