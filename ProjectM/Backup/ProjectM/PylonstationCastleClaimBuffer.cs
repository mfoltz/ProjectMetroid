// Decompiled with JetBrains decompiler
// Type: ProjectM.PylonstationCastleClaimBuffer
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
  public struct PylonstationCastleClaimBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleClaimGuid;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IPylonstationCastleDataBufferElement_get_DataGuid_Private_Virtual_Final_New_get_PrefabGUID_0;
    [FieldOffset(0)]
    public PrefabGUID CastleClaimGuid;

    public virtual unsafe PrefabGUID ProjectM\u002EIPylonstationCastleDataBufferElement\u002EDataGuid
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationCastleClaimBuffer.NativeMethodInfoPtr_ProjectM_IPylonstationCastleDataBufferElement_get_DataGuid_Private_Virtual_Final_New_get_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static PylonstationCastleClaimBuffer()
    {
      Il2CppClassPointerStore<PylonstationCastleClaimBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PylonstationCastleClaimBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationCastleClaimBuffer>.NativeClassPtr);
      PylonstationCastleClaimBuffer.NativeFieldInfoPtr_CastleClaimGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationCastleClaimBuffer>.NativeClassPtr, nameof (CastleClaimGuid));
      PylonstationCastleClaimBuffer.NativeMethodInfoPtr_ProjectM_IPylonstationCastleDataBufferElement_get_DataGuid_Private_Virtual_Final_New_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationCastleClaimBuffer>.NativeClassPtr, 100683461);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationCastleClaimBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
