// Decompiled with JetBrains decompiler
// Type: ProjectM.CrowdednessPlayerBufferElement
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
  public struct CrowdednessPlayerBufferElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sources;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAlly;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSource_Public_Boolean_CrowdednessSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSource_Public_Void_CrowdednessSource_Boolean_0;
    [FieldOffset(0)]
    public double Time;
    [FieldOffset(8)]
    public int UserIndex;
    [FieldOffset(12)]
    public CrowdednessSource Sources;
    [FieldOffset(13)]
    public bool IsAlly;

    [CallerCount(0)]
    public unsafe bool HasSource(CrowdednessSource source)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &source;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CrowdednessPlayerBufferElement.NativeMethodInfoPtr_HasSource_Public_Boolean_CrowdednessSource_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 988612, RefRangeEnd = 988614, XrefRangeStart = 988612, XrefRangeEnd = 988612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSource(CrowdednessSource source, bool set)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &set;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CrowdednessPlayerBufferElement.NativeMethodInfoPtr_SetSource_Public_Void_CrowdednessSource_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CrowdednessPlayerBufferElement()
    {
      Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CrowdednessPlayerBufferElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr);
      CrowdednessPlayerBufferElement.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr, nameof (Time));
      CrowdednessPlayerBufferElement.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr, nameof (UserIndex));
      CrowdednessPlayerBufferElement.NativeFieldInfoPtr_Sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr, nameof (Sources));
      CrowdednessPlayerBufferElement.NativeFieldInfoPtr_IsAlly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr, nameof (IsAlly));
      CrowdednessPlayerBufferElement.NativeMethodInfoPtr_HasSource_Public_Boolean_CrowdednessSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr, 100676265);
      CrowdednessPlayerBufferElement.NativeMethodInfoPtr_SetSource_Public_Void_CrowdednessSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr, 100676266);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CrowdednessPlayerBufferElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
