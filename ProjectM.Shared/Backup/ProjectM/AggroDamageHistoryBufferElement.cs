// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroDamageHistoryBufferElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AggroDamageHistoryBufferElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_Fake;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToBuffer_Public_Void_DynamicBuffer_1_AggroDamageHistoryBufferElement_0;
    [FieldOffset(0)]
    public double Time;
    [FieldOffset(8)]
    public float Value;
    [FieldOffset(12)]
    public Entity Source;
    [FieldOffset(20)]
    public bool Fake;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 723015, RefRangeEnd = 723018, XrefRangeStart = 723012, XrefRangeEnd = 723015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddToBuffer(
      DynamicBuffer<AggroDamageHistoryBufferElement> buffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &buffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroDamageHistoryBufferElement.NativeMethodInfoPtr_AddToBuffer_Public_Void_DynamicBuffer_1_AggroDamageHistoryBufferElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AggroDamageHistoryBufferElement()
    {
      Il2CppClassPointerStore<AggroDamageHistoryBufferElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroDamageHistoryBufferElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroDamageHistoryBufferElement>.NativeClassPtr);
      AggroDamageHistoryBufferElement.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroDamageHistoryBufferElement>.NativeClassPtr, nameof (Time));
      AggroDamageHistoryBufferElement.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroDamageHistoryBufferElement>.NativeClassPtr, nameof (Value));
      AggroDamageHistoryBufferElement.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroDamageHistoryBufferElement>.NativeClassPtr, nameof (Source));
      AggroDamageHistoryBufferElement.NativeFieldInfoPtr_Fake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroDamageHistoryBufferElement>.NativeClassPtr, nameof (Fake));
      AggroDamageHistoryBufferElement.NativeMethodInfoPtr_AddToBuffer_Public_Void_DynamicBuffer_1_AggroDamageHistoryBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroDamageHistoryBufferElement>.NativeClassPtr, 100663876);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroDamageHistoryBufferElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
