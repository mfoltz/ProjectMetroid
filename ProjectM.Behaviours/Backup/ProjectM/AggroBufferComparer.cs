// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroBufferComparer
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AggroBufferComparer
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_AggroBuffer_AggroBuffer_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1320904, RefRangeEnd = 1320910, XrefRangeStart = 1320901, XrefRangeEnd = 1320904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(AggroBuffer a, AggroBuffer b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroBufferComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_AggroBuffer_AggroBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AggroBufferComparer()
    {
      Il2CppClassPointerStore<AggroBufferComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (AggroBufferComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroBufferComparer>.NativeClassPtr);
      AggroBufferComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_AggroBuffer_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroBufferComparer>.NativeClassPtr, 100663368);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroBufferComparer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
