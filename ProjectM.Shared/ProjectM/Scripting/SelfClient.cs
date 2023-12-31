// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.SelfClient
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SelfClient
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_SelfClient_0;
    [FieldOffset(0)]
    public Entity Id;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator Entity(SelfClient selfClient)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &selfClient;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelfClient.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_SelfClient_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SelfClient()
    {
      Il2CppClassPointerStore<SelfClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (SelfClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelfClient>.NativeClassPtr);
      SelfClient.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelfClient>.NativeClassPtr, nameof (Id));
      SelfClient.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelfClient>.NativeClassPtr, 100668423);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SelfClient>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
