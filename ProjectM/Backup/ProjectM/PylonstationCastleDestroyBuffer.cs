﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.PylonstationCastleDestroyBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PylonstationCastleDestroyBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleDestroyGuid;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IPylonstationCastleDataBufferElement_get_DataGuid_Private_Virtual_Final_New_get_PrefabGUID_0;
    [FieldOffset(0)]
    public PrefabGUID CastleDestroyGuid;

    public virtual unsafe PrefabGUID ProjectM\u002EIPylonstationCastleDataBufferElement\u002EDataGuid
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationCastleDestroyBuffer.NativeMethodInfoPtr_ProjectM_IPylonstationCastleDataBufferElement_get_DataGuid_Private_Virtual_Final_New_get_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static PylonstationCastleDestroyBuffer()
    {
      Il2CppClassPointerStore<PylonstationCastleDestroyBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PylonstationCastleDestroyBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationCastleDestroyBuffer>.NativeClassPtr);
      PylonstationCastleDestroyBuffer.NativeFieldInfoPtr_CastleDestroyGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationCastleDestroyBuffer>.NativeClassPtr, nameof (CastleDestroyGuid));
      PylonstationCastleDestroyBuffer.NativeMethodInfoPtr_ProjectM_IPylonstationCastleDataBufferElement_get_DataGuid_Private_Virtual_Final_New_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationCastleDestroyBuffer>.NativeClassPtr, 100683463);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationCastleDestroyBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
