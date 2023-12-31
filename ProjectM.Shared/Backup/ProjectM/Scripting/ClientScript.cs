// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ClientScript
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.Scripting
{
  public class ClientScript : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientScript()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientScript>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScript.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientScript()
    {
      Il2CppClassPointerStore<ClientScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ClientScript));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientScript>.NativeClassPtr);
      ClientScript.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScript>.NativeClassPtr, 100668422);
    }

    public ClientScript(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
