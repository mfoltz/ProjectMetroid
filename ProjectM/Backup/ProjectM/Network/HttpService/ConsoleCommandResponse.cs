// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.HttpService.ConsoleCommandResponse
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network.HttpService
{
  public class ConsoleCommandResponse : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_output;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConsoleCommandResponse()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCommandResponse>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleCommandResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConsoleCommandResponse()
    {
      Il2CppClassPointerStore<ConsoleCommandResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network.HttpService", nameof (ConsoleCommandResponse));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleCommandResponse>.NativeClassPtr);
      ConsoleCommandResponse.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCommandResponse>.NativeClassPtr, nameof (output));
      ConsoleCommandResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandResponse>.NativeClassPtr, 100691901);
    }

    public ConsoleCommandResponse(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string output
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleCommandResponse.NativeFieldInfoPtr_output)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleCommandResponse.NativeFieldInfoPtr_output), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
